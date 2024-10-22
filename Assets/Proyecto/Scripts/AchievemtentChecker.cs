using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AchievemtentChecker : MonoBehaviour
{   

    public AvastAchievement avastAchievement;

    [SerializeField]  public bool AvastActive;

      public McAfee mcAfee;

    [SerializeField] public bool McAfeeActive;

    public PortalAchievement portalAchievement;

    [SerializeField] public bool portalActive;

    public WinAchievement winAchievement;

    [SerializeField] public bool GameFinishedActive;

    public ejemploEvento EjemploEvento; 
    public bool CoinActive = false;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {CoinActive = false;
    GameFinishedActive = false;
    portalActive = false;
    McAfeeActive = false;
    AvastActive = false;

    }

    // Update is called once per frame
    void Update()
    {
       
        checkAchievement(); 
    }

    public void checkAchievement()
    {
        
        /*AvastActive = avastAchievement.checkAchievement();
        McAfeeActive = mcAfee.checkAchievement();
        portalActive = portalAchievement.checkAchievement();
        GameFinishedActive = winAchievement.checkAchievement();
        */
    }

    public void SetAvast()
    {
        AvastActive = true;
    }
       public void SetMcAfee()
    {
        McAfeeActive = true;
    }
       public void SetPortal()
    {
        portalActive = true;
    }
       public void SetGame()
    {
        GameFinishedActive = true;
    }

    public bool ReturnAvast()
    {
        return AvastActive;
    }
       public bool returnAfee()
    {
        return McAfeeActive;
    }
       public bool returnPortal()
    {
        return portalActive;
    }
       public bool returnGameFinishe()
    {
        return GameFinishedActive;
    }

}
