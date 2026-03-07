using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OneColliderTrigger : MonoBehaviour
{
    private Collider lastColider;

    protected virtual void OnOneTriggerEnter(Collider other) {}
    private void OnTriggerEnter(Collider other)
    {
        if (lastColider != null && lastColider != other) return;

        lastColider = other;

        OnOneTriggerEnter(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if(lastColider == other) lastColider = null;
    }
}
