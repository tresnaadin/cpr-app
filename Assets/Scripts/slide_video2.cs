using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class slide_video2 : MonoBehaviour
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
 
 
    //Membuat fungsi agar dapat berpindah scene dengan nama slide_video1 dan slide_video3
    public void slide_video1()
    {
           SceneManager.LoadScene("slide_video1");
    }
    public void slide_video3()
    {
            SceneManager.LoadScene("slide_video3");
    }
}