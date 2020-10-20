using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentMissingSwap : EquipmentStatusObject
{
    public GameObject obj;

    public override void SwapStatus(bool status)
    {
        Debug.Log(name + ": Missing " + status);

        obj.SetActive(status);
    }
}
