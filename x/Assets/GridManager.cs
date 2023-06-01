using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    private int height;
    [SerializeField] private GameObject gridPrefab;
    [SerializeField] private Transform referans;
    private GameObject[] dizi;
    int i = 0;

    void Start()
    {
        height = PlayerPrefs.GetInt("y");
        dizi = new GameObject[height * height];
        i = 0;
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < height; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GameObject gridObject = Instantiate(gridPrefab, new Vector3(referans.position.x + x, referans.position.y + y), Quaternion.identity);

                dizi[i] = gridObject;
                i++;
                gridObject.transform.parent = transform;
            }
        }
    }


    void Update()
    {
        for (int a = 0; a < dizi.Length; a++)
        {
            if (a == (height - 1) + dizi.Length - 100 || a == (height - 1) + dizi.Length - 90 || a == (height - 1) + dizi.Length - 80 || a == (height - 1) + dizi.Length - 70 || a == (height - 1) + dizi.Length - 60 || a == (height - 1) + dizi.Length - 50 || a == (height - 1) + dizi.Length - 40 || a == (height - 1) + dizi.Length - 30 || a == (height - 1) + dizi.Length - 20 || a == (height - 1) + dizi.Length - 10 || a == (height - 1) + dizi.Length)
            {
                if (a != 0)
                {
                    a++;
                }
            }
            if (a < dizi.Length - 2 && dizi[a].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + 1].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + 2].transform.GetChild(0).GetComponent<Image>().enabled == true)
            {
                dizi[a].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + 1].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + 2].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
            if (a == (height - 1) + dizi.Length - 100 || a == (height - 1) + dizi.Length - 90 || a == (height - 1) + dizi.Length - 80 || a == (height - 1) + dizi.Length - 70 || a == (height - 1) + dizi.Length - 60 || a == (height - 1) + dizi.Length - 50 || a == (height - 1) + dizi.Length - 40 || a == (height - 1) + dizi.Length - 30 || a == (height - 1) + dizi.Length - 20 || a == (height - 1) + dizi.Length - 10 || a == (height - 1) + dizi.Length)
            {
                if (a != 0)
                {
                    a++;
                }
            }
            if (a < dizi.Length -(height*2) && dizi[a].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + height].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + (height * 2)].transform.GetChild(0).GetComponent<Image>().enabled == true)
            {
                dizi[a].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + height].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + (height * 2)].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
            if (a < dizi.Length - height && dizi[a].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + 1].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + height].transform.GetChild(0).GetComponent<Image>().enabled == true)
            {
                dizi[a].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + 1].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + height].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
            if (a < dizi.Length - (height+1) && dizi[a].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + 1].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + height + 1].transform.GetChild(0).GetComponent<Image>().enabled == true)
            {
                dizi[a].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + 1].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + height + 1].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
            if (a < dizi.Length - (height+1) && dizi[a].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + height].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + height + 1].transform.GetChild(0).GetComponent<Image>().enabled == true)
            {
                dizi[a].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + height].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + height + 1].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
            if (a < dizi.Length- (height + 1) && dizi[a+1].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + height].transform.GetChild(0).GetComponent<Image>().enabled == true && dizi[a + height + 1].transform.GetChild(0).GetComponent<Image>().enabled == true)
            {
                dizi[a+1].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + height].transform.GetChild(0).GetComponent<Image>().enabled = false;
                dizi[a + height + 1].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
        }
    }
}
