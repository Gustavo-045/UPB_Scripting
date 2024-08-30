using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public GameObject PanelInstrucciones;
    public GameObject PanelCreditos;

    public GameObject WikiPanel;

    public GameObject BytePanel;


    // Start is called before the first frame update
    public void OnButton()
    {
        SceneManager.LoadScene("level 1");
    }

      public void BackToMenu()
    {
        PanelInstrucciones.SetActive(false);
        PanelCreditos.SetActive(false);
    }

        public void LoadInstructions()
    {
        PanelInstrucciones.SetActive(true);
    }

          public void LoadCredits()
    {
        PanelCreditos.SetActive(true);
    }

    public void ReloadLevel1()
    {
        SceneManager.LoadScene("level 1");
    }

    public void OpenWiki()
    {
        WikiPanel.SetActive(true);
    }

        public void CloseWiki()
    {
        WikiPanel.SetActive(false);
    }

            public void OpenByte()
    {
        BytePanel.SetActive(true);
    }

                public void CloseByte()
    {
        BytePanel.SetActive(false);
    }

 


    // Update is called once per frame
    void Update()
    {
        
    }
}
