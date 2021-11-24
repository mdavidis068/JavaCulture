using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transisi : MonoBehaviour
{
    public static string SJATIM;

    public void Kamera(string Senjata )
    {
        //KumpulanSuara.instance.Panggil_Suara(0);
        this.gameObject.SetActive(true);
        SJATIM = Senjata;
        //GetComponent<Animator>().Play("End");
    }

    public void Object_InActive()
    {
        this.gameObject.SetActive(false);
    }

    public void Pindah_Scene()
    {
        SceneManager.LoadScene(SJATIM);
    }

   
}
