using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentLogLine : MonoBehaviour
{
    private List<EquipmentInfoNode> nodes;
    public TMP_Dropdown EquipmentDropdown, ProblemDropdown;

    private List<string> equipmentOptions = new List<string>(),
        problemOptions = new List<string>();
    private int CurrentIndex;

    public Toggle FlyableToggle;


    public void Setup(List<EquipmentInfoNode> nodes)
    {
        if (nodes != null)
        {
            this.nodes = nodes;
            EquipmentDropdown.ClearOptions();
            equipmentOptions = new List<string>();
            equipmentOptions.Add("");
            foreach (var node in nodes)
            {
                equipmentOptions.Add(node.EquipmentName);
            }

            EquipmentDropdown.AddOptions(equipmentOptions);
            ProblemDropdown.ClearOptions();
            EquipmentDropdown.onValueChanged.AddListener(delegate { ChangeSelection(); });
        }
    }

    public void ChangeSelection()
    {
        Debug.Log("Change Selection");
        CurrentIndex = EquipmentDropdown.value;
        if (CurrentIndex <= 0)
        {
            ProblemDropdown.ClearOptions();
        }
        else
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].EquipmentName == EquipmentDropdown.captionText.text)
                {
                    SetSelection(nodes[i]);
                    return;
                }
            }
        }
    }

    public void SetSelection(EquipmentInfoNode equipmentnode)
    {
        Debug.Log("SetSelection");
        problemOptions.Clear();
        problemOptions.Add("");
        foreach (var error in equipmentnode.PossibleEquipmentErrors)
        {
            problemOptions.Add(error);
        }
        ProblemDropdown.ClearOptions();
        ProblemDropdown.AddOptions(problemOptions);
    }
}
