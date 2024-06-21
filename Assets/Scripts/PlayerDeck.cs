using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    
    public Card temp = new Card();
    public int x;
    public int deckSize;
    public List<Card> deck = new List<Card>();


    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;
    public GameObject cardInDeck5;
    public GameObject cardInDeck6;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        for(int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1, 2);
            deck[i] = CardDatabase.cardList[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(deckSize < 1)
        {
            cardInDeck1.SetActive(false);
            cardInDeck2.SetActive(false);
            cardInDeck3.SetActive(false);
            cardInDeck4.SetActive(false);
            cardInDeck5.SetActive(false);
            cardInDeck6.SetActive(false);
        }
        else if (deckSize <= 10)
        {
            cardInDeck1.SetActive(true);
            cardInDeck2.SetActive(false);
            cardInDeck3.SetActive(false);
            cardInDeck4.SetActive(false);
            cardInDeck5.SetActive(false);
            cardInDeck6.SetActive(false);
        }
        else if (deckSize <= 20)
        {
            cardInDeck1.SetActive(true);
            cardInDeck2.SetActive(true);
            cardInDeck3.SetActive(false);
            cardInDeck4.SetActive(false);
            cardInDeck5.SetActive(false);
            cardInDeck6.SetActive(false);
        }
        else if (deckSize <= 30)
        {
            cardInDeck1.SetActive(true);
            cardInDeck2.SetActive(true);
            cardInDeck3.SetActive(true);
            cardInDeck4.SetActive(false);
            cardInDeck5.SetActive(false);
            cardInDeck6.SetActive(false);
        }
        else if (deckSize <= 40)
        {
            cardInDeck1.SetActive(true);
            cardInDeck2.SetActive(true);
            cardInDeck3.SetActive(true);
            cardInDeck4.SetActive(true);
            cardInDeck5.SetActive(false);
            cardInDeck6.SetActive(false);
        }
        else if (deckSize <= 50)
        {
            cardInDeck1.SetActive(true);
            cardInDeck2.SetActive(true);
            cardInDeck3.SetActive(true);
            cardInDeck4.SetActive(true);
            cardInDeck5.SetActive(true);
            cardInDeck6.SetActive(false);
        }
        else
        {
            cardInDeck1.SetActive(true);
            cardInDeck2.SetActive(true);
            cardInDeck3.SetActive(true);
            cardInDeck4.SetActive(true);
            cardInDeck5.SetActive(true);
            cardInDeck6.SetActive(true);
        }

    }

    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            temp = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }
}
