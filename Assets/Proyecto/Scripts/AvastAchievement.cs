using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class AvastAchievement : MonoBehaviour
{
    public bool active;
    public AchievemtentChecker achievemtentChecker;
   
    // Start is called before the first frame update
    void Start()
    {
        achievemtentChecker = GameObject.FindWithTag("LogroChecker").GetComponent<AchievemtentChecker>();
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D()
    {
        Debug.Log("xd");
        MMAchievementManager.UnlockAchievement("Avast");
        achievemtentChecker.SetAvast();

    }

    public bool checkAchievement()
    { 
        Debug.Log("se devolvio true");
        return active;
        
    }
}
