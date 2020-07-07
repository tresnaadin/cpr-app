using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class slide_video1 : MonoBehaviour
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
 
 
    //Membuat fungsi agar dapat berpindah scene dengan nama blsScene3 dan slide_video2
    public void blsScene3()
    {
           SceneManager.LoadScene("bls_scene3");
    }
    public void slide_video2()
    {
            SceneManager.LoadScene("slide_video2");
    }
}