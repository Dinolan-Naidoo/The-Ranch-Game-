using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Menu_Control : MonoBehaviour
{
    //UI references 
    public GameObject ShopMenuUI;
    public GameObject PlantInstructionsMenuUI;
    public GameObject AnimalInstructionsMenuUI;

    //Audio
    public AudioSource OpenTextBoxFX;

    void Start()
    {
        ShopMenuUI.SetActive(false);
        PlantInstructionsMenuUI.SetActive(false);
        AnimalInstructionsMenuUI.SetActive(false);
    }

    //Opens plant menu
    public void OpenPlantInstructions()
    {
        PlantInstructionsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        OpenTextBoxFX.Play();
    }

    //Closes plant menu
    public void ClosePlantInstructions()
    {
        PlantInstructionsMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    //Opens shop menu
    public void OpenShop()
    {
        ShopMenuUI.SetActive(true);
        Time.timeScale = 0f;
        OpenTextBoxFX.Play();
    }

    //Closes shop menu
    public void CloseShop()
    {
        ShopMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    //Opens animal menu
    public void OpenAnimalInstructions()
    {
        AnimalInstructionsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        OpenTextBoxFX.Play();
    }

    //Closes animal menu
    public void CloseAnimalInstructions()
    {
        AnimalInstructionsMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

}
