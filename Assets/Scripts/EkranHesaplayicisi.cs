using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EkranHesaplayicisi 
{
    static float sol; //Ekranýn sol kýsmý
    static float sag; //Ekranýn sað kýsmý
    static float ust; //Ekranýn ust kýsmý
    static float alt; //Ekranýn alt kýsmý

    /// <summary>
    /// Ekranýn sol kenarýnýn koordinatlarýný verir.
    /// </summary>
    public static float Sol
    {
        get
        {
            return sol;
        }
    }

    /// <summary>
    /// Ekranýn sað kenarýnýn koordinatlarýný verir.
    /// </summary>
    public static float Sag
    {
        get
        {
            return sag;
        }
    }


    /// <summary>
    /// Ekranýn üst kenarýnýn koordinatlarýný verir.
    /// </summary>
    public static float Ust
    {
        get
        {
            return ust;
        }
    }


    /// <summary>
    /// Ekranýn alt kenarýnýn koordinatlarýný verir.
    /// </summary>
    public static float Alt
    {
        get
        {
            return alt;
        }
    }


    public static void Init()  //Baþlangýçta yapýlan hesaplamalara initialize denir.Kýsaca init dedik.
    {
        float ekranZekseni = -Camera.main.transform.position.z;
        Vector3 solAltKose = new Vector3(0, 0, ekranZekseni);
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZekseni); //Oyunun çalýþacaðý ekraný bilmeden sað üst köþe koordinatlarýný bilemiyoruz.

        Vector3 solAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(solAltKose);//Oyun dünyasýndaki koordinatlara çevirme.
        Vector3 sagUstKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(sagUstKose);//Oyun dünyasýndaki koordinatlara çevirme.

        sol = solAltKoseOyunDunyasi.x;
        sag = sagUstKoseOyunDunyasi.x;
        ust = sagUstKoseOyunDunyasi.y;
        alt = solAltKoseOyunDunyasi.y;
    }

}
