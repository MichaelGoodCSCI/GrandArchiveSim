using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int id { get; set; }
    public string cardName { get; set; }
    public ElementType element { get; set; }
    public DeckType deckType { get; set; }
    public int? reserveCost { get; set; }
    public int? memoryCost { get; set; }
    public int? power { get; set; }
    public int? life { get; set; }
    public bool? fastSpeed { get; set; }
    public MainType types { get; set; }
    public List<ClassesType> classes { get; set; }
    public List<string> subTypes { get; set; }
    public List<Ability> abilities { get; set; }
    public Sprite cardArt { get; set; }
}
