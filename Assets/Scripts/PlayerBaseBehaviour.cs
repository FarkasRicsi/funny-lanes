using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseBehaviour : MonoBehaviour
{
    public EColor color = EColor.Green;

    [SerializeField]
    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        changeColor();
    }


    
    public void OnMouseUp()
    {
        changeColor();
    }
    
    public void changeColor()
    {
        if (color == EColor.Green)
        {
            color = EColor.Purple;
            spriteRenderer.color = Color.magenta;
        }
        else if (color == EColor.Purple)
        {
            color = EColor.Green;
            spriteRenderer.color = Color.green;
        }
    }
}
