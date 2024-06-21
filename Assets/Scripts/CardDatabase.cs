using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using UnityEngine.EventSystems;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card()
        {
            id = 0,
            cardName = "Lost Spirit",
            element = ElementType.Norm,
            deckType = DeckType.Material,
            memoryCost = -1,
            life = 15,
            types = MainType.Champion,
            classes = new List<ClassesType>() { ClassesType.Spirit },
            abilities = new List<Ability>() { 
                new Ability() {
                    effect = new List<Effect>() {
                        new Effect() {
                            effect = new List<EffectType>() { EffectType.Draw },
                            effectAmount = 7
                        }
                    },
                    trigger = TriggerType.OnEnter,
                    isClassBonus = false
                }
            },
            cardArt = Resources.Load <Sprite>("lost-spirit-demo22")
        });
        cardList.Add(new Card()
        {
            id = 1,
            cardName = "Trained Sharpshooter",
            element = ElementType.Norm,
            deckType = DeckType.Main,
            reserveCost = 3,
            power = 2,
            life = 3,
            types = MainType.Ally,
            classes = new List<ClassesType>() { ClassesType.Ranger },
            subTypes = new List<string>() { "Human" },
            abilities = new List<Ability>() {
                new Ability() {
                    effect = new List<Effect>() {
                        new Effect() {
                            effect = new List<EffectType>() { EffectType.Ranged },
                            effectAmount = 2
                        }
                    },
                    trigger = TriggerType.Passive,
                    isClassBonus = true
                }
            },
            cardArt = Resources.Load<Sprite>("trained-sharpshooter-alc")
        });
        cardList.Add(new Card()
        {
            id = 2,
            cardName = "Evasive Maneuvers",
            element = ElementType.Norm,
            deckType = DeckType.Main,
            reserveCost = 1,
            types = MainType.Action,
            fastSpeed = true,
            classes = new List<ClassesType>() { ClassesType.Ranger },
            subTypes = new List<string>() { "Skill", "Reaction"},
            abilities = new List<Ability>() {
                new Ability() {
                    effect = new List<Effect>() {
                        new Effect() {
                            effect = new List<EffectType>() { EffectType.Shield, EffectType.Distance },
                            effectAmount = 2,
                            targets = new List<TargetType>() { TargetType.Champion, TargetType.Ally },
                            targetAmount = 1
                        }
                    },
                    trigger = TriggerType.OnEnter,
                    isClassBonus = false,
                }
            },
            cardArt = Resources.Load<Sprite>("evasive-maneuvers-alcsd")
        });
    }
}
