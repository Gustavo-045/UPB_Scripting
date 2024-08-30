using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public GameObject PanelInstrucciones;

    // Start is called before the first frame update
    public void OnButton()
    {
        SceneManager.LoadScene("level 1");
    }

      public void BackToMenu()
    {
        PanelInstrucciones.SetActive(false);
    }

        public void LoadInstructions()
    {
        PanelInstrucciones.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
