using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AturDeskripsi : MonoBehaviour
{
    [Header("Deskripsi Masakan")]

    public TrackableAR[] ar;

    public string[] nama;
    [TextArea]
    
    public string[] deskripsi;
    [Header("UI Deskripsi")]

    public Text txtNama;

    public Text txtDeskripsi;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ar.Length; i++)
        {
            if (ar[i].GetMarker())
            {
                txtNama.text = nama[i];
                txtDeskripsi.text = deskripsi[i];
            }
        }
    }
}
