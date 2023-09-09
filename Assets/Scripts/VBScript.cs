using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript : MonoBehaviour, IVirtualButtonEventHandler
{
    //public GameObject[] video;
    //public AturDeskripsi deskripsi;

    string vbName;

    public VirtualButtonBehaviour[] vButton;

    // Start is called before the first frame update
    void Start()
    {
        //deskripsi.GetComponentsInChildren<AturDeskripsi>();
        vButton = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vButton.Length; i++)
        {
            vButton[i].RegisterEventHandler(this);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (vbName == "VB1")
        {
            //deskripsi.MunculDeskripsi();
            Debug.Log("vb1 pressed");
        }
        else if (vbName == "VB2")
        {

            Debug.Log("vb2 pressed");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
}
