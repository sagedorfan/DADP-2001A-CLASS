using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    public Sword(string name, string damage) : base(name, damage)
    {
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log("the sword attacks with a slash");
    }
}
