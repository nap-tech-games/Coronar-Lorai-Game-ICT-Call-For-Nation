using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public float TimeStart;
    public Text textbox;
    public GameObject Uipanel;

   
    public GameObject[] Lefthand;
    public GameObject[] Righthand;

   
    AudioSource cs, ws;

    // Start is called before the first frame update
    void Start()
    {
        cs = GameObject.Find("ClockSound").GetComponent<AudioSource>();
        ws = GameObject.Find("WinSound").GetComponent<AudioSource>();
        cs.Play();
        
        textbox.text = TimeStart.ToString();
        Uipanel.SetActive(false);

        Lefthand.SetValue(true, 1, 2, 3);
        Righthand.SetValue(true, 1, 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
      
        TimeStart -= Time.deltaTime;
        textbox.text = "" + (int)TimeStart;

        if (TimeStart <= 0f)
        {
            ws.Play();
            Uipanel.SetActive(true);
            textbox.text = "" + (int)0f;
            cs.Stop();
        }

        if (TimeStart <= 18f)
        {
            Lefthand[0].SetActive(false);
            Righthand[0].SetActive(false);
        }

        if (TimeStart <= 10f)
        {
            Lefthand[1].SetActive(false);
            Righthand[1].SetActive(false);
        }

        if (TimeStart <= 2f)
        {
            Lefthand[2].SetActive(false);
            Righthand[2].SetActive(false);
        }
        
    }
}
