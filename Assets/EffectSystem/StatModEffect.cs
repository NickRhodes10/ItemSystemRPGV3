using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effect/Stat Modifier")]
public class StatModEffect : EffectBase
{
    public override void OnTrigger(PlayerProxy character)
    {
        Debug.Log(effectDescription);   
    }

}
