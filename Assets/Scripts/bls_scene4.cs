using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bls_scene4 : MonoBehaviour
{
    // Use this for initialization
    void Start () {
       
    }
   
    // Update is called once per frame
    void Update () {
 
        //Kondisi ketika ada Input dari keyboard
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();     //Fungsi untuk keluar dari game / aplikasi
            Debug.Log("Quit Game"); //Mencetak output string pada Console
        }
    }
 
 
    //Membuat fungsi agar dapat berpindah scene dengan nama MainMenu, blsscene3, blsscene5
    public void MainMenu()
    {
           SceneManager.LoadScene("MainMenu");
    }
    public void blsscene3()
    {
           SceneManager.LoadScene("bls_scene3");
    }
    public void blsscene5()
    {
           SceneManager.LoadScene("bls_scene5");
    }
}
