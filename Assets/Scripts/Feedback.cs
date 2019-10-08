using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback : MonoBehaviour
{

    public GameObject feedbackObject;


    private float ShowTime = 2;
    private Coroutine feedbackCoroutine = null;
    private float LastTime = -1;

    void Start()
    {
        feedbackObject.SetActive(false);
    }

    public void ShowFeedBack(Vector3 position)
    {
        feedbackObject.SetActive(true);
        position.y += 0.03f;
        feedbackObject.transform.position = position;
        LastTime = Time.time + ShowTime;
        if (feedbackCoroutine == null)
        {
            feedbackCoroutine = StartCoroutine(Hide());
        }

    }

    private IEnumerator Hide()
    {
        while (Time.time <= LastTime)
        {
            yield return new WaitForEndOfFrame();
        }
        feedbackObject.SetActive(false);
        feedbackCoroutine = null;
    }
}
