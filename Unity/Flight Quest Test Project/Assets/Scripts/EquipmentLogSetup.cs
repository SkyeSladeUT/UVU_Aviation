using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentLogSetup : MonoBehaviour
{
    public List<EquipmentInfoNode> equipments;
    public float numLines;
    public EquipmentLogLine LinePrefab;
    public bool InitOnAwake;
    private List<EquipmentLogLine> Lines;
    private EquipmentLogLine temp;

    private void Start()
    {
        if(InitOnAwake)
            Initialize();
    }

    public void Initialize()
    {
        Lines = new List<EquipmentLogLine>();
        if (numLines > 0)
        {
            LinePrefab.Setup(equipments);
            Lines.Add(LinePrefab);
            if (numLines > 1)
            {
                for (int i = 1; i < numLines; i++)
                {
                    temp = Instantiate(LinePrefab, LinePrefab.transform.parent);
                    temp.Setup(equipments);
                    Lines.Add(temp);
                }
            }
        }
    }
    
}
