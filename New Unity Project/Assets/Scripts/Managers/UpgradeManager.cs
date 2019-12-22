using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeManager : MonoBehaviour
{
    public UpgradeMenu upgradeMenu;
    public GameManager gameManager;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;

    void Start()
    {
        nameText.text = upgradeMenu.name;
        levelText.text = upgradeMenu.level.ToString();
    }

    void Update()
    {
        
    }

    public void UpgradeLevel()
    {
        if(gameManager.currentBalance >= upgradeMenu.chosenPrice) 
        {
            upgradeMenu.level += 1;
            levelText.text = upgradeMenu.level.ToString();
            gameManager.currentBalance -= upgradeMenu.chosenPrice;
        }
    }

    private void OnApplicationQuit()
    {
        
    }
}
