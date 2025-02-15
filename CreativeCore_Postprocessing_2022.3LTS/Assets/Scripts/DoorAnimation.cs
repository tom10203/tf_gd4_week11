using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print($"ontrigger call");
        animator.SetBool("DoorOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("DoorOpen", false);
    }
}
