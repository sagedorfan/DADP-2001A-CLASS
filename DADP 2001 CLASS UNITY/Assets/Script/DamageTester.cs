using UnityEngine;
using UnityEngine.InputSystem;

public class DamageTester : MonoBehaviour
{
    public GameObject[] enemies;
    public int damageAmount = 10;
    private void OnDAmage(InputAction.CallbackContext context)
    {
        if (!context.performed) return; 
        foreach (GameObject enemy in enemies) 
        {
            if (enemy == null) continue;

            IDamageable damageable = GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(damageAmount);
            }
        }
    }
}
