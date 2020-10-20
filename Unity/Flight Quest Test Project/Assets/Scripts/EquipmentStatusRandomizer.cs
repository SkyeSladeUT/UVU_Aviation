using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentStatusRandomizer : MonoBehaviour
{
    public List<EquipmentStatus> equipments;
    private List<EquipmentStatus> equipmentsleft;
    private int randomNum;
    public float numberOfProblems;

    public void Randomize()
    {
        equipmentsleft = equipments;
        if (numberOfProblems > equipments.Count)
        {
            numberOfProblems = equipments.Count;
        }
        for (int i = 0; i < numberOfProblems; i++)
        {
            randomNum = Random.Range(0, equipmentsleft.Count - 1);
            equipmentsleft[randomNum].SetStatus(false);
            equipmentsleft.RemoveAt(randomNum);
        }
    }
    
}
