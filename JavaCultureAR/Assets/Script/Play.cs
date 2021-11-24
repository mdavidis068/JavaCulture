using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Play : MonoBehaviour
{
    public string MenuAplikasi;
    public Transform loadingfill;

    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan;
    // Start is called before the first frame update

    void Update()
    {
        if (nilaiSekarang < 100)
        {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log((int)nilaiSekarang);
        }
        else
        {
            SceneManager.LoadScene("MenuAplikasi");
        }
        loadingfill.GetComponent<Image>().fillAmount = nilaiSekarang / 100;
       
    }
    
}
