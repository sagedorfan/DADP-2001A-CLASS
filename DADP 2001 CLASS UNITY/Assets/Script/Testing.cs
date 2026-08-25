using UnityEngine;
using MyGame.Charecters;

public class testing : MonoBehaviour
{
    public hero myHero;
    public enemy myEnemy;

    private void Start()
    {
        myHero.PrintHealth();   
        myEnemy.PrintHealth();
    }
}
