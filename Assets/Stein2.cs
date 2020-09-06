using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Stein2 : MonoBehaviour
{
    [SerializeField] private Sprite withoutFoam;
    [SerializeField] private Sprite withFoam;

    [SerializeField] private float showWithFoamDelay = 3f;
    [SerializeField] private float showWithoutFoamDelay = 2f;
    
    private SpriteRenderer steinRenderer;

    private Coroutine showWithFoamCoroutine;
    
    private void Start()
    {
        steinRenderer = GetComponent<SpriteRenderer>();

        steinRenderer.sprite = withoutFoam;

        // - много лишнего кода, который захламляет класс
        // - нужно придумывать название каждому вызываемому методу
        StartCoroutine(ShowWithFoam());
    }

    private IEnumerator ShowWithFoam()
    {
        yield return new WaitForSeconds(showWithFoamDelay);
        
        steinRenderer.sprite = withFoam;

        StartCoroutine(ShowWithoutFoam());
    }

    private IEnumerator ShowWithoutFoam()
    {
        yield return new WaitForSeconds(showWithoutFoamDelay);
        
        steinRenderer.sprite = withoutFoam;
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
