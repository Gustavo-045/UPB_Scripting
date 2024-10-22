using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class PortalAchievement : MonoBehaviour
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

    public void UnlockPortal()
    {
        MMAchievementManager.UnlockAchievement("Portal");
        achievemtentChecker.SetPortal();
        active = true;

    }

    public bool checkAchievement()
    {
        return active;
    }
}
