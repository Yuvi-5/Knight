using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        // Check if left mouse button (button 0) is pressed
        if (Input.GetMouseButtonDown(0))
        {
            // Trigger the attack animation
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }
}
