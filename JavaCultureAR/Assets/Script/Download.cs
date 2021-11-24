using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Download : MonoBehaviour
{
    public void DownloadClicked()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1OnJCRiUFyFnggEMlScN5favIPk_yPdDm?usp=sharing");
    }
}
