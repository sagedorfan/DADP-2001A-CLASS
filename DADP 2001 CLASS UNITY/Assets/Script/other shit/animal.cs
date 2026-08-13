using Unity.VisualScripting.FullSerializer;
using UnityEngine;



public class animal : MonoBehaviour
{
    private int arms;
    private int legs;
    private string species;

    public animal()
    {
        Debug.Log("animal created");

    }
    public animal(int numArms, int numLegs, string newSpecies)
    {
        arms = numArms;
        legs = numLegs;
        species = newSpecies;
    }

 public animal(string newSpecies,  int numArms, int numLegs)
    { 
        animal myAnimal = new animal();
        animal myDog = new animal("dog",0, 4);    
    }

}


