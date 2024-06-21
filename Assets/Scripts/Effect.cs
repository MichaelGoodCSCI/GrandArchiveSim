using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public List<EffectType> effect { get; set; }
    public List<TargetType> targets { get; set; }
    public int? targetAmount { get; set; }
    public int? effectAmount { get; set; }
}