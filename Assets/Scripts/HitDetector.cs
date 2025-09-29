using UnityEngine;

public class HitDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyController enemyController =  other.GetComponent<EnemyController>();
            if (enemyController  != null)
            {
                enemyController.GotHit();
            }
        }
    }
}