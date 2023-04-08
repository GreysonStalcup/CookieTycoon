using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    public Controller controller;

    public Upgrades cookieUpgrade;
    public string cookieUpgradeName;
    public double cookieUpgradeBaseCost;
    public double cookieUpgradeCostMult;

    public void StartUpgradeManager() 
    {
        cookieUpgradeName = "Cookies Per Click";
        cookieUpgradeBaseCost = 10;
        cookieUpgradeCostMult = 1.5;
        UpdateUpgradeUI();
    }

    public void UpdateUpgradeUI() 
    {
        cookieUpgrade.LevelText.text = controller.gameData.cookieUpgradeLevel.ToString();
        cookieUpgrade.CostText.text = "Cost: " + Cost().ToString( format: "F2") + " Cookies";
        cookieUpgrade.NameText.text = "+1 " + cookieUpgradeName;
    }
    public double Cost() => cookieUpgradeBaseCost * System.Math.Pow(cookieUpgradeCostMult, controller.gameData.cookieUpgradeLevel);

    public void BuyCookieUpgrade() 
    {
        if (controller.gameData.cookies >= Cost()) 
        {
            controller.gameData.cookies -= Cost();
            controller.gameData.cookieUpgradeLevel += 1;
            UpdateUpgradeUI();
        }
    }
}
