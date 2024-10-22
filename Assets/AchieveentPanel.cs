using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchieveentPanel : MonoBehaviour
{

     public AchievemtentChecker achievemtentChecker;

     public bool Afee;
     public bool avast;
     public bool portal;
     public bool win;

     public GameObject afeeIcon;
    // Start is called before the first frame update
    void Start()
    {
        win = false;
        avast = false;
        portal = false;
        win = false;
        achievemtentChecker = GameObject.FindWithTag("LogroChecker").GetComponent<AchievemtentChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        Afee = achievemtentChecker.returnAfee();

        if(Afee)
        {
            afeeIcon.SetActive(true);

        }
        
    }
}
