using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EkranHesaplayicisi 
{
    static float sol; //Ekran�n sol k�sm�
    static float sag; //Ekran�n sa� k�sm�
    static float ust; //Ekran�n ust k�sm�
    static float alt; //Ekran�n alt k�sm�

    /// <summary>
    /// Ekran�n sol kenar�n�n koordinatlar�n� verir.
    /// </summary>
    public static float Sol
    {
        get
        {
            return sol;
        }
    }

    /// <summary>
    /// Ekran�n sa� kenar�n�n koordinatlar�n� verir.
    /// </summary>
    public static float Sag
    {
        get
        {
            return sag;
        }
    }


    /// <summary>
    /// Ekran�n �st kenar�n�n koordinatlar�n� verir.
    /// </summary>
    public static float Ust
    {
        get
        {
            return ust;
        }
    }


    /// <summary>
    /// Ekran�n alt kenar�n�n koordinatlar�n� verir.
    /// </summary>
    public static float Alt
    {
        get
        {
            return alt;
        }
    }


    public static void Init()  //Ba�lang��ta yap�lan hesaplamalara initialize denir.K�saca init dedik.
    {
        float ekranZekseni = -Camera.main.transform.position.z;
        Vector3 solAltKose = new Vector3(0, 0, ekranZekseni);
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZekseni); //Oyunun �al��aca�� ekran� bilmeden sa� �st k��e koordinatlar�n� bilemiyoruz.

        Vector3 solAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(solAltKose);//Oyun d�nyas�ndaki koordinatlara �evirme.
        Vector3 sagUstKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(sagUstKose);//Oyun d�nyas�ndaki koordinatlara �evirme.

        sol = solAltKoseOyunDunyasi.x;
        sag = sagUstKoseOyunDunyasi.x;
        ust = sagUstKoseOyunDunyasi.y;
        alt = solAltKoseOyunDunyasi.y;
    }

}
