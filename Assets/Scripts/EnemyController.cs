using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");

        // Notify GameManager
        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(1); // Add 1 point per hit
        }
    }
}