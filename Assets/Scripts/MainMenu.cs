using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //namespace ini kita butuhkan agar dapat memanggil fungsi yang ada pada class SceneManagement
 
public class MainMenu : MonoBehaviour {
 
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
 
 
    //Membuat fungsi agar dapat berpindah scene dengan nama MainGame
    public void BlsScene()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
           SceneManager.LoadScene("bls_scene");
    }
    public void AboutScene()
    {
           SceneManager.LoadScene("about_scene");
    }
    public void CardiacScene()
    {
           SceneManager.LoadScene("cardiac_scene");
    }
    public void QuizIntro()
    {
           SceneManager.LoadScene("quiz_opening");
    }
}