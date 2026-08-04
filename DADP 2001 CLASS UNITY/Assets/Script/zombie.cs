using UnityEngine;

public class zombie : MonoBehaviour
{
    private int arms;
    private int legs;
    private string name;

    public zombie()
    {
        Debug.Log("zombie created");
    }

    public zombie(int arms, string name, int legs)
    {
        _arms = numArms;
        _legs = numlegs;
       _name = newName;
    }

    public int getArms()
    {
        return _arms;

    }

    public void setLegs(int legs)
    {
        _legs = newLegs;
    }

   public int getLegs()
    {
        return _legs;
    }

    public zombie (string name, int arms,  int legs)
    {
        zombie myZombie =new zombie();
        zombie myChuck =new zombie("Chuck", 1, 2);
    }

    public void SetLegs(int legs)
    {
        _legs = 0;
    }

    public int getArms()
    {
        Debug.Log("Chuck has", arms);
         
    }

    public int getLegs()
    {
        Debug.Log("Chuck has",  legs);
    }

}