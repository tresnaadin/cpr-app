using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quiz_opening : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Kondisi ketika ada Input dari keyboard
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();     //Fungsi untuk keluar dari game / aplikasi
            Debug.Log("Quit Game"); //Mencetak output string pada Console
        }
    }
    
    //Membuat fungsi agar dapat berpindah scene dengan nama MainMenu dan Quiz
    public void MainMenu()
    {
           SceneManager.LoadScene("MainMenu");
    }
    public void Quiz()
    {
            SceneManager.LoadScene("quiz_scene");
    }
}
