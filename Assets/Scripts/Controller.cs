using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
  public UpgradesManager upgradesManager;
  public GameData gameData;
  [SerializeField] private TMP_Text cookiesText;
  [SerializeField] private TMP_Text cookieClickPowerText;
  
  public double ClickPower() => 1+ gameData.cookieUpgradeLevel;

  private void Start() 
  {
    gameData = new GameData();
    upgradesManager.StartUpgradeManager();
  }
  private void Update() 
  {
    cookiesText.text = gameData.cookies.ToString();
    cookieClickPowerText.text = "+" + ClickPower() + " Cookies";
  }

  public void AddCookies() 
  {
    gameData.cookies+= ClickPower();
  }
} 
