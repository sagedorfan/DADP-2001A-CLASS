using UnityEngine;

[CreateAssetMenu(fileName = "PotionData", menuName = "Scriptable Object/potion Data")]

public class PotionData : ScriptableObject
{
    public string potionName;
    public int health;
    internal string healAmount;
}