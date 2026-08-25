using UnityEngine;

public class Testing : MonoBehaviour
{
    public PotionData potion;

    private void Start()
    {
        Debug.Log("potion:" + potion.potionName + "heals for" + potion.healAmount);
    }
}
