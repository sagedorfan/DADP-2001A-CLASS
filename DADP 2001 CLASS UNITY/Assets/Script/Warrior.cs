using UnityEngine;
using UnityEngine.Windows.Speech;

public class Warrior : charecter
{
    public string Weapon;

    public Warrior (string weapon, string name): base(name)
    {
        Weapon = weapon;
    }
    
}