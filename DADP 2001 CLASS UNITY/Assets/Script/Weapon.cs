using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string Name;
    public string Damage;
   

    public Weapon(string name, string damage)   
    {
        Name = name;
        Damage = damage;
    }
    public virtual void Attack()
    {
        Debug.Log( Name  + "dealt" + Damage );
    }

}