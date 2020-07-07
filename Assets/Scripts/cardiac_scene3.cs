using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cardiac_scene3 : MonoBehaviour
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
 
 
    //Membuat fungsi agar dapat berpindah scene dengan nama MainMenu, cardiac_scene2, dan cardiac_scene4
    public void MainMenu()
    {
           SceneManager.LoadScene("MainMenu");
    }
    public void cardiac_scene2()
    {
            SceneManager.LoadScene("cardiac_scene");
    }
    public void cardiac_scene4()
    {
            SceneManager.LoadScene("cardiac_scene4");
    }
}