using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFlashTime : MonoBehaviour
{
    public Renderer meshRenderer;
    public Material onMat, offMat;

    private bool active;
    private bool running;
    private Coroutine flashFunc;

    public float onTime;
    public float offTime;

    public void SetOnFlashTime(float value)
    {
        onTime = value;
    }

    public void SetOffFlashTime(float value)
    {
        offTime = value;
    }

    public void StartFlash()
    {
        running = true;
        flashFunc = StartCoroutine(MaterialFlash());
    }

    private IEnumerator MaterialFlash()
    {
        while (running)
        {
            if (active)
            {
                yield return new WaitForSeconds(onTime);
                active = false;
                MaterialSwap();
            }
            else
            {
                yield return new WaitForSeconds(offTime);
                active = true;
                MaterialSwap();
            }
        }
    }

    public void EndFlash()
    {
        running = false;
        if(flashFunc!= null)
            StopCoroutine(flashFunc);
    }

    private void MaterialSwap()
    {
        meshRenderer.material = (active) ? onMat : offMat;
    }
    
}
