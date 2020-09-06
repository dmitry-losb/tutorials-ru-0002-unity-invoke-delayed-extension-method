using System;
using System.Collections;
using UnityEngine;

public static class MonoBehaviourExtensionMethods
{
    public static Coroutine InvokeDelayed(this MonoBehaviour monoBehaviour, Action action, float delay)
    {
        return monoBehaviour.StartCoroutine(InvokeDelayedImpl(action, delay));
    }

    private static IEnumerator InvokeDelayedImpl(Action action, float time)
    {
        yield return new WaitForSeconds(time);

        action?.Invoke();
    }
}
