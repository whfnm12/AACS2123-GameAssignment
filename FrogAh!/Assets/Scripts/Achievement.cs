using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    private Image img;
    
    public enum AchievementTypes { babyJump, dummy2, dummy3 };
    
    [SerializeField] private AchievementTypes achievementType;
    public AchievementTypes _achievementType { get { return achievementType; } }

    [SerializeField] private string TrophyName;
    [SerializeField] private string TrophyDesc;


    public bool isUnlocked { get; private set; }

    public void Awake()
    {
        img = GetComponent<Image>();
        CheckIfAchievementIsUnlocked();
    }
    public void CheckIfAchievementIsUnlocked()
    {
        if (PlayerPrefs.GetInt(achievementType.ToString()) == 0)
        {
            img.color = Color.black;
        }
        else
        {
            img.color = Color.white;
            isUnlocked = true;
        }
    }

    public void UnlockThisAchievement()
    {
        PlayerPrefs.SetInt(achievementType.ToString(), 1);
        CheckIfAchievementIsUnlocked();
    }

    //public void OnTouchTrophy()
    //{
    //    AchievementManager.Instance.UpdateTrophyTextsUI(TrophyName, TrophyDesc);
    //}
}
