using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    
    // Start is called before the first frame update
    public void OnButton()
    {
        SceneManager.LoadScene("level 1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}