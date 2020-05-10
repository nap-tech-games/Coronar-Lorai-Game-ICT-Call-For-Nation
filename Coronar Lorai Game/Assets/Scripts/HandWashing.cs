using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HandWashing : MonoBehaviour, IPointerDownHandler,IPointerUpHandler ,IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    
    private GameObject clock;

    AudioSource cs, PI;
   

    private void Awake()
    {
        clock =GameObject.Find("Clock");
        clock.SetActive(false);

        cs = GameObject.Find("ClockSound").GetComponent<AudioSource>();
        PI = GameObject.Find("PickItem").GetComponent<AudioSource>();

        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("onDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        clock.SetActive(true);
        cs.mute = false;


    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("onEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        clock.SetActive(false);
        cs.mute = true;
       
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        PI.Play();
        Debug.Log("onPointerDown");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        cs.mute = true;
        Debug.Log("OnPonterUp");
    }
}
