using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get reference to the Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if left mouse button (button 0) is pressed
        if (Input.GetMouseButtonDown(0))
        {
            // Trigger the attack animation
            animator.SetTrigger("Attack");
        }
    }
}
