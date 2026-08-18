using UnityEngine;

public class Bow : Weapon
{
    public Bow(string name, string damage) : base(name, damage)
    {
    }
    public override void Attack()
    {
        base.Attack();
        Debug.Log("the arrow shoots");
    }
}
