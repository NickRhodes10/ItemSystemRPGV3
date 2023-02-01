using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerProxy : MonoBehaviour
{
    public delegate void OnHit(PlayerProxy character);
    public OnHit onHit;

    public EquipItem equipItem;

    private void Start()
    {
        if(equipItem != null)
        {
            equipItem.OnEquip(this);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            onHit(this);
        }
    }

    public void DealDamage(PlayerProxy target)
    {
        onHit(target);
    }
}
