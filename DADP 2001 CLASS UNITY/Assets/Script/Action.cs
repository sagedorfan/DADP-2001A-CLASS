using UnityEngine;

public class Action : MonoBehaviour
{
    void Start()
    {
        Warrior warrior = gameObject.AddComponent<Warrior>();

        warrior.Name = "sqneeze";
        warrior.Weapon = "flying shark tornado javlin";

        Debug.Log(warrior.Name);
        Debug.Log(warrior.Weapon);
    }
}
