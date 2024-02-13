using UnityEngine;

    public class PhysicController:MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Coin"))
            {
                Destroy(other.gameObject);
                ScoreManager.Score += 10;
            }
        }
    
    }


