using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUtama : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject PanelTentang;
    public GameObject PanelPanduan;
    public GameObject PanelMulai;
    public GameObject PanelJATIM;
    public GameObject PanelJATENG;
    public GameObject PanelJABAR;
    public GameObject PanelProv;
    public GameObject PanelKeluar;
    public GameObject PanelSJATIM;
    public GameObject PanelBJATIM;
    public GameObject PanelRJATIM;
    public GameObject SJATENG;
    public GameObject BJATENG;
    public GameObject RJATENG;
    public GameObject SJABAR;
    public GameObject BJABAR;
    public GameObject RJABAR;

    void Start()
    {
        MenuPanel.SetActive(true);
        PanelTentang.SetActive(false);
        PanelPanduan.SetActive(false);
        PanelJATIM.SetActive(false);
        PanelJATENG.SetActive(false);
        PanelJABAR.SetActive(false);
        PanelProv.SetActive(false);
        PanelKeluar.SetActive(false);
    }

    public void PanelTentangClicked ()
    {
        MenuPanel.SetActive(false);
        PanelTentang.SetActive(true);
        PanelPanduan.SetActive(false);
        PanelJATIM.SetActive(false);
        PanelProv.SetActive(false);
        PanelKeluar.SetActive(false);
    }

    public void BackClicked()
    {
        MenuPanel.SetActive(true);
        PanelTentang.SetActive(false);
        PanelPanduan.SetActive(false);
        PanelJATIM.SetActive(false);
        PanelProv.SetActive(false);
        PanelKeluar.SetActive(false);
        PanelJATENG.SetActive(false);
    }

    public void PanelPanduanClicked()
    {
        MenuPanel.SetActive(false);
        PanelTentang.SetActive(false);
        PanelPanduan.SetActive(true);
        PanelJATIM.SetActive(false);
        PanelProv.SetActive(false);
        PanelKeluar.SetActive(false);
    }

    public void PanelMulaiClicked()
    {
        MenuPanel.SetActive(false);
        PanelTentang.SetActive(false);
        PanelPanduan.SetActive(false);
        PanelJATIM.SetActive(false);
        PanelProv.SetActive(true);
        PanelKeluar.SetActive(false);
    }

    public void PanelKeluarClicked()
    {
        MenuPanel.SetActive(false);
        PanelTentang.SetActive(false);
        PanelPanduan.SetActive(false);
        PanelJATIM.SetActive(false);
        PanelProv.SetActive(false);
        PanelKeluar.SetActive(true);
    }

    public void PanelJATIMClicked()
    {
        MenuPanel.SetActive(false);
        PanelTentang.SetActive(false);
        PanelPanduan.SetActive(false);
        PanelJATIM.SetActive(true);
        PanelRJATIM.SetActive(true);
        PanelProv.SetActive(false);
        PanelKeluar.SetActive(false);
    }

    public void NextClicked()
    {
        PanelSJATIM.SetActive(true);
        PanelBJATIM.SetActive(false);
        PanelRJATIM.SetActive(false);
    }

    public void Next1Clicked()
    {
        PanelSJATIM.SetActive(false);
        PanelBJATIM.SetActive(true);
        PanelRJATIM.SetActive(false);
    }

    public void KembaliClicked()
    {
        PanelSJATIM.SetActive(false);
        PanelBJATIM.SetActive(false);
        PanelRJATIM.SetActive(false);
        PanelProv.SetActive(true);
    }

    public void PanelJATENGClicked()
    {
        MenuPanel.SetActive(false);
        PanelTentang.SetActive(false);
        PanelPanduan.SetActive(false);
        PanelJATENG.SetActive(true);
        RJATENG.SetActive(true);
        PanelProv.SetActive(false);
        PanelKeluar.SetActive(false);
    }

    public void NextJatengClicked()
    {
        SJATENG.SetActive(true);
        BJATENG.SetActive(false);
        RJATENG.SetActive(false);
    }

    public void NextJateng1Clicked()
    {
        SJATENG.SetActive(false);
        BJATENG.SetActive(true);
        RJATENG.SetActive(false);
    }

    public void Kembali1Clicked()
    {
        PanelJATIM.SetActive(false);
        PanelJABAR.SetActive(false);
        PanelJATENG.SetActive(false);
        PanelProv.SetActive(true);
    }

    public void PanelJABARClicked()
    {
        MenuPanel.SetActive(false);
        PanelTentang.SetActive(false);
        PanelPanduan.SetActive(false);
        PanelJABAR.SetActive(true);
        RJABAR.SetActive(true);
        PanelProv.SetActive(false);
        PanelKeluar.SetActive(false);
    }

    public void NextJabarClicked()
    {
        SJABAR.SetActive(true);
        BJABAR.SetActive(false);
        RJABAR.SetActive(false);
    }

    public void NextJabar1Clicked()
    {
        SJABAR.SetActive(false);
        BJABAR.SetActive(true);
        RJABAR.SetActive(false);
    }

    public void KameraClicked()
    {
        SceneManager.LoadScene("SJATIM");
    }

    public void KameraB()
    {
        SceneManager.LoadScene("BJATIM");
    }

    public void KameraR()
    {
        SceneManager.LoadScene("RJATIM");
    }

    public void KamerSJABAR()
    {
        SceneManager.LoadScene("SJABAR");
    }

    public void KamerBJABAR()
    {
        SceneManager.LoadScene("BJABAR");
    }

    public void KamerRJABAR()
    {
        SceneManager.LoadScene("RJABAR");
    }

    public void KamerSJATENG()
    {
        SceneManager.LoadScene("SJATENG");
    }

    public void KamerRJATENG()
    {
        SceneManager.LoadScene("RJATENG");
    }

    public void KamerBJATENG()
    {
        SceneManager.LoadScene("BJATENG");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
