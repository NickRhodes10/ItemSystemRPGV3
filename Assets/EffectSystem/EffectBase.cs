using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EffectBase : ScriptableObject
{
    public string effectDescription;

    // When the effect is called, need to know who is using it and what target, if any.
    public abstract void OnTrigger(PlayerProxy character);
}
