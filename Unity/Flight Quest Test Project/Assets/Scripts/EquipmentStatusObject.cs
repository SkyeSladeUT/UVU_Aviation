using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquipmentStatusObject : MonoBehaviour
{
    private void Awake()
    {
        SwapStatus(true);
    }

    public abstract void SwapStatus(bool status);
}
