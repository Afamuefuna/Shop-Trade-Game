using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPartsUnanim : MonoBehaviour
{
    [SerializeField] SpriteRenderer eyes, hair;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] Sprite[] eyes_img_X, eyes_img_Y, hair_img_X, hair_img_Y;

    void LateUpdate()
    {
        if (playerMovement.movementDirection.x >= 0 || playerMovement.movementDirection.x <= 0)
        {
            customizeChar(playerMovement.movementDirection.x, eyes, eyes_img_X);
            customizeChar(playerMovement.movementDirection.x, hair, hair_img_X);
        }
        if(playerMovement.movementDirection.y >= 0 || playerMovement.movementDirection.y <= 0)
        {
            customizeChar(playerMovement.movementDirection.y, eyes, eyes_img_Y);
            customizeChar(playerMovement.movementDirection.y, hair, hair_img_Y);
        }
    }

    void customizeChar(float direction, SpriteRenderer spriteRenderer, Sprite[] sprite)
    {
        switch (direction)
        {
            case 0:
                spriteRenderer.sprite = sprite[0];
                break;
            case 1:
                spriteRenderer.sprite = sprite[1];
                break;
            case -1:
                spriteRenderer.sprite = sprite[2];
                break;
            default:
                break;
        }
    }
}
