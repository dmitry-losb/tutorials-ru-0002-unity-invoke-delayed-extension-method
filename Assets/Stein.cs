using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Stein : MonoBehaviour
{
    [SerializeField] private Sprite withoutFoam;
    [SerializeField] private Sprite withFoam;

    [SerializeField] private float showWithFoamDelay = 3f;
    [SerializeField] private float showWithoutFoamDelay = 2f;
    
    private SpriteRenderer steinRenderer;
    
    private Coroutine showWithFoamCoroutine;

    private void Awake()
    {
        steinRenderer = GetComponent<SpriteRenderer>();
        steinRenderer.sprite = withoutFoam;
    }

    private void Start()
    {
        showWithFoamCoroutine = this.InvokeDelayed(() =>
        {
            steinRenderer.sprite = withFoam;
            showWithFoamCoroutine = this.InvokeDelayed(() =>
            {
                steinRenderer.sprite = withoutFoam;
                showWithFoamCoroutine = null;
            }, showWithoutFoamDelay);
        }, showWithFoamDelay);

        // this.InvokeDelayed(ShowWithFoam, showWithFoamDelay);
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (showWithFoamCoroutine != null)
            {
                StopCoroutine(showWithFoamCoroutine);
                showWithFoamCoroutine = null;
            }
        }
    }

    // private void ShowWithFoam()
    // {
    //     steinRenderer.sprite = withFoam;
    // }
}














