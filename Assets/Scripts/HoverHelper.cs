using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverHelper : MonoBehaviour
{
    public Text Helper;

    private Dictionary<Hoverable, string> msgs = new Dictionary<Hoverable, string>();

    private void Start()
    {
        msgs.Add(Hoverable.Bird, "Bird!");
        msgs.Add(Hoverable.CoffeeBot, "Get coffee");
        msgs.Add(Hoverable.Coin, "Coin");
        msgs.Add(Hoverable.DoorToMarket, "Market");
        msgs.Add(Hoverable.DoorToSecurityRoom, "Security Room");
        msgs.Add(Hoverable.FishVendor, "Get fish");
        msgs.Add(Hoverable.Glasses, "Funny Mask");
        msgs.Add(Hoverable.Guard, "Guard");
        msgs.Add(Hoverable.LaserGrid, "Secret Room");
        msgs.Add(Hoverable.Picture, "Frank J.");
        msgs.Add(Hoverable.Soda, "Get soda");

        SetHoverText("");
    }

    public void OnHover(string _hoverable)
    {
        Hoverable hoverable = Hoverable.None;
        try
        {
            hoverable = (Hoverable)Enum.Parse(typeof(Hoverable), _hoverable);
        }
        catch { }
        ShowHelperText(hoverable);

    }
    public void OnHoverExit()
    {
        CleanHoverText();
    }
    private void ShowHelperText(Hoverable hoverable)
    {
        if (hoverable != Hoverable.None)
        {
            string message = msgs[hoverable];
            SetHoverText(message);
        }
    }

    private void CleanHoverText()
    {
        SetHoverText("");
    }
    private void SetHoverText(string text)
    {
        Helper.text = text;
    }
}

public enum Hoverable
{
    Bird,
    Glasses,
    CoffeeBot,
    Coin,
    Soda,
    FishVendor,
    Picture,
    LaserGrid,
    Guard,
    DoorToSecurityRoom,
    DoorToMarket,
    None
}
