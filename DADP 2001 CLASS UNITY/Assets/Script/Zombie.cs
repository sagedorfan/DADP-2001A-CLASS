using UnityEngine;

public class Zombie : MonoBehaviour, IDamageable
{
    public void TakeDamage()
    {
        Debug.Log("damage was taken");
    }
}
