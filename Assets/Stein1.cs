using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Stein1 : MonoBehaviour
{
    [SerializeField]
    private Sprite withoutFoam;
    [SerializeField]
    private Sprite withFoam;
    [SerializeField]
    private float delay = 3f;
    [SerializeField]
    private float delayBack = 2f;
    
    private SpriteRenderer steinRenderer;

    private Coroutine showWithFoamCoroutine;
    
    private void Start()
    {
        steinRenderer = GetComponent<SpriteRenderer>();

        steinRenderer.sprite = withoutFoam;

        Invoke(nameof(ShowWithFoam), delay);
        
        // - нельзя передать аргументы
        // - много лишнего кода, который захламляет класс
        // - нужно придумывать название для каждого метода, который хотим отложенно вызвать
        // - намного хуже для производительности чем через Coroutine, так как использует рефлексию под капотом
        // + немного меньше кода надо написать чем через корутины
        // + работает :) 
    }

    private void ShowWithFoam()
    {
        steinRenderer.sprite = withFoam;
        Invoke(nameof(ShowWithoutFoam), delayBack);
    }

    private void ShowWithoutFoam()
    {
        steinRenderer.sprite = withFoam;
    }

    // private void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         if (showWithFoamCoroutine != null)
    //         {
    //             StopCoroutine(showWithFoamCoroutine);
    //         }
    //     }
    // }
    
}
