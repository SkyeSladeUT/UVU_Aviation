using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartEvent : MonoBehaviour
{
    public UnityEvent OnStart;
    public float waitTime;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(waitTime);
        OnStart.Invoke();
    }
}
