using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int  displayId;

    public int id;
    public string cardName;
    public Sprite cardSprite;
    public Image cardImage;

    public bool cardBack;
    public static bool staticCardBack;

    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cardSprite = displayCard[0].cardArt;
        cardImage.sprite = cardSprite;
    }

    // Update is called once per frame
    void Update()
    {
        staticCardBack = cardBack;
    }
}
