using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EquipmentEventSwap : EquipmentStatusObject
{
    public UnityEvent goodEvent, badEvent;
    
    public override void SwapStatus(bool status)
    {
        Debug.Log(name + ": Event " + status);

        if(status)
            goodEvent.Invoke();
        else
            badEvent.Invoke();
    }
}
