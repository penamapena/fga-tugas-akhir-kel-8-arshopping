using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class showDescription : MonoBehaviour
{
    [Header("Deskripsi Furniture")]
    public TrackableAR[] tr;
    public string[] nama;
    [TextArea]
    public string[] harga;
    [TextArea]
    public string[] material;
    [TextArea]
    public string[] dimensi;

    [Header("UI Deskripsi")]
    public TextMeshProUGUI txtNama;
    public TextMeshProUGUI txtHarga;
    public TextMeshProUGUI txtMaterial;
    public TextMeshProUGUI txtDimensi;

    void Start()
    {

    }

    void Update()
    {
        for(int i=0; i < tr.Length; i++)
        {
            if(tr[i].GetMarker())
            {
                txtNama.text = nama[i];
                txtHarga.text = harga[i];
                txtMaterial.text = material[i];
                txtDimensi.text = dimensi[i];
            }
        }
    }
}