using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentPositionSwap : EquipmentStatusObject
{
    public Transform obj;
    public Transform goodTransform;
    public Transform badTransform;

    public override void SwapStatus(bool status)
    {
        Debug.Log(name + ": Position " + status);
        obj.transform.position = (status) ? goodTransform.position : badTransform.position;
        obj.transform.rotation = (status) ? goodTransform.rotation : badTransform.rotation;
    }
}
