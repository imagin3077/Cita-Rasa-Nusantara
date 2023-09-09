using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bgm : MonoBehaviour
{
    public Button button;
    private bool isOn = true;
    public AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            isOn = false;
            bgm.Pause();
        }
        else
        {
            isOn = true;
            bgm.Play();
        }
    }
}
