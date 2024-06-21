using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public List<Effect> effect { get; set; } 
    public int? cost { get; set; }
    public TriggerType trigger { get; set; } 
    public bool isClassBonus { get; set; }
    public int? levelRequirement { get; set; }
}