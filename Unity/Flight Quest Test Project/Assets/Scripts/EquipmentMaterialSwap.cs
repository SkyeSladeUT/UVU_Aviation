using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EquipmentMaterialSwap : EquipmentStatusObject
{
    public Renderer meshrender;
    public Material goodmaterial, badmaterial;
    
    
    public override void SwapStatus(bool status)
    {
        Debug.Log(name + ": Material " + status);
        meshrender.material = (status) ? goodmaterial : badmaterial;
    }
}
