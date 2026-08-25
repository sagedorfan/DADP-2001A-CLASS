using UnityEngine;

namespace MyGame.Charecters
{
    public class hero : MonoBehaviour
    {
        public int health = 100 ; 

        public void PrintHealth()
        {
            Debug.Log("Hero has" + health);
        }
    }

    public class enemy : MonoBehaviour
    {
        public int health = 25;

        public void PrintHealth()
        {
            Debug.Log("Enemy has" + health);
        }
    }
}


