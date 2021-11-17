using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D mRigidbody;
    public List<Animator> characterPartsAnim = new List<Animator>();

    public Vector2 movementDirection;

    private void Update()
    {
        movementDirection.x = Input.GetAxisRaw("Horizontal");
        movementDirection.y = Input.GetAxisRaw("Vertical");

        foreach (Animator animator in characterPartsAnim)
        {
            animator.SetFloat("Horizontal", movementDirection.x);
            animator.SetFloat("Vertical", movementDirection.y);
            animator.SetFloat("Speed", movementDirection.magnitude);
        }
    }

    private void FixedUpdate()
    {
        mRigidbody.MovePosition(mRigidbody.position + movementDirection * moveSpeed * Time.fixedDeltaTime);
    }

    public void findAndAddAnimators(string tag, List<Animator> animator)
    {
        foreach (var item in GameObject.FindGameObjectsWithTag(tag))
        {
            animator.Add(item.GetComponent<Animator>());
        };
    }

    private void Awake()
    {
        findAndAddAnimators("characterParts", characterPartsAnim);
    }
}
