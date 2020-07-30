using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{

    double rNumber;
    public GameObject selectLvl;
    public GameObject mainMenu;

    void Start()
    {
        ShowMainMenu();
    }
    public void PlayNow()
    {
        rNumber = Random.Range(0, 3);
        Debug.Log(rNumber);
        if (rNumber == 0) SceneManager.LoadScene("Beers");
        else if ( rNumber == 1) SceneManager.LoadScene("Cocktails");
        else if (rNumber == 2) SceneManager.LoadScene("Other Drinks");

    }
    public void LoadBeers()
    {
        SceneManager.LoadScene("Beers");
    }
    public void LoadCocktails()
    {
        SceneManager.LoadScene("Cocktails");
    }
    public void LoadOthers()
    {
        SceneManager.LoadScene("Other Drinks");
    }
    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        selectLvl.SetActive(false);
    }
    public void SelectLvl()
    {
        selectLvl.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
