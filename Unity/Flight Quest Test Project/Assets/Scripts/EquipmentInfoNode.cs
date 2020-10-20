using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "UIData/EquipmentNode")]
public class EquipmentInfoNode : ScriptableObject
{
    public string EquipmentName;
    public List<string> PossibleEquipmentErrors;
    
}
