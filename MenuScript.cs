using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Comic()
    {
        SceneManager.LoadScene("Comic");
    }
        public void Comic2()
    {
        SceneManager.LoadScene("Comic2");
    }
        public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
        public void Mapa1()
    {
        SceneManager.LoadScene("plantacionalbertomontañas");
    }
            public void Mapa2()
    {
        SceneManager.LoadScene("Mapa 2");
    }
            public void Mapa3()
    {
        SceneManager.LoadScene("Mapa 3");
    }


    public void exit()
    {
        Application.Quit();
    }
}
