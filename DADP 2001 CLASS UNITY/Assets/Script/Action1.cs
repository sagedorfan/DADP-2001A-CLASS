using System.Collections.Generic;
using UnityEngine;

public class Action1 : MonoBehaviour
{
      void start()
    {
        Sword sword =gameObject.AddComponent<Sword>();
        Bow bow =gameObject.AddComponent<Bow>();    

        List<Weapon> weapons = new List<Weapon> { sword, bow};

        foreach (Weapon weapon in weapons)
        {
            weapon.Attack();
        }

    }

       
}
