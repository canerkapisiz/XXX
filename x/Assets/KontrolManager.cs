using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KontrolManager : MonoBehaviour
{
    [SerializeField] private Image img;

    GridManager gridManager = new GridManager();

    public void ButonaBasildi()
    {
        gridManager = FindObjectOfType<GridManager>();
        Debug.Log("Bastın");

        img.transform.GetChild(0).GetComponent<Image>().enabled = true;
    }

    
}
