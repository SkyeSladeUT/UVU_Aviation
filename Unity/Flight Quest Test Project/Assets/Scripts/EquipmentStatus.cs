using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentStatus : MonoBehaviour
{
    private bool satisfactory = true;
    public List<EquipmentStatusObject> statusChanges;
    private int randomNum;
    
    public void SetStatus(bool status)
    {
        if (statusChanges.Count <= 0)
        {
            return;
        }
        if (statusChanges.Count == 1)
        {
            statusChanges[0].SwapStatus(status);
        }
        else if (statusChanges.Count > 1)
        {
            randomNum = Random.Range(0, statusChanges.Count);
            statusChanges[randomNum].SwapStatus(status);
        }
    }
    
    
}
