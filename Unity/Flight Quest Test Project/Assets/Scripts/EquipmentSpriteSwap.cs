using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSpriteSwap : EquipmentStatusObject
{
    public SpriteRenderer spriteRenderer;
    public Sprite goodSprite, badSprite;
    
    public override void SwapStatus(bool status)
    {
        spriteRenderer.sprite = (status) ? goodSprite : badSprite;
    }
}
