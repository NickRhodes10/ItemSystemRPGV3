using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponEquip : EquipItem
{
    // Settings for weapon SO

    public Vector2Int minimumDamageRange;      
    public Vector2Int maximumDamageRange;
    public AttackSpeed attackSpeed;
    public DamageTypes damageTypes;

    // Array for when we hit a target, play these effects
    public EffectBase[] hitEffects;

    public override void OnEquip(PlayerProxy character)
    {
        base.OnEquip(character);

        for (int i = 0; i < hitEffects.Length; i++)
        {
            character.onHit += hitEffects[i].OnTrigger;
        }
    }

    public enum AttackSpeed
    {
        VerySlow,
        Slow,
        Normal,
        Fast,
        VeryFast
    }

    
}
