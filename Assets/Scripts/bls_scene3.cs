﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bls_scene3 : MonoBehaviour
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
 
 
    //Membuat fungsi agar dapat berpindah scene dengan nama MainMenu dan BlsScene2
    public void MainMenu()
    {
           SceneManager.LoadScene("MainMenu");
    }
    public void BlsScene2()
    {
            SceneManager.LoadScene("bls_scene2");
    }
    public void bls_aed()
    {
            SceneManager.LoadScene("bls_aedintro");
    }
    public void bls_rjp()
    {
            SceneManager.LoadScene("bls_rjp");
    }
    public void slide_video1()
    {
            SceneManager.LoadScene("slide_video1");
    }
}
