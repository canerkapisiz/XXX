using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GirisManager : MonoBehaviour
{
    [SerializeField] public InputField yukseklik;
    public int  yukseklikSayi;

    public void yukseklikDegeri()
    {
        yukseklikSayi = int.Parse(yukseklik.text);
        PlayerPrefs.SetInt("y", yukseklikSayi);
    }

    public void Kaydet()
    {
        if(yukseklik.text == "" || yukseklikSayi>10)
        {
            yukseklikSayi = 10;
        }

        Debug.Log("y" + yukseklikSayi);
        SceneManager.LoadScene(1);
    }
}
