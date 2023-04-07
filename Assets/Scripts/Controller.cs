using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
  public GameData gameData;
  [SerializeField] private TMP_Text cookiesText;
  
  private void Start() 
  {
    gameData = new GameData();
  }
  private void Update() 
  {
    cookiesText.text = gameData.cookies + " Cookies";
  }

  public void AddCookies() 
  {
    gameData.cookies++;
  }
} 
