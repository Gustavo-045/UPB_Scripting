using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class WinAchievement : MonoBehaviour
{
    public bool active;
    public AchievemtentChecker achievemtentChecker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        MMAchievementManager.UnlockAchievement("WinGame");
        achievemtentChecker.SetGame();
        active = true;
    }

    public bool checkAchievement()
    {
        return active;
    }
}
