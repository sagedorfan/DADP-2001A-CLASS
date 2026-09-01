using UnityEngine;

public class Orc : MonoBehaviour, IDamageable
{
    public void TakeDamage()
    {
        Debug.Log("damage was taken");
    }
}
