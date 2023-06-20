using CharacterCretor.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] UIpanels;
    public GameObject[] FemalePanels;
    public GameObject[] MalePanels;
    public GameObject[] PlayerGender;
    public GameObject SkinColors;
    public int currentGender; // Cinsiyet 
    public void goCharacterGengerSelect()
    {
        UIpanels[0].SetActive(false);//Main Panel
        UIpanels[1].SetActive(true);//CharacterGnegerPanel
    }
    public void SetGender(int gender)
    {
        currentGender = gender;  
        PlayerPrefs.SetInt("Gender",currentGender);
        if (gender == 1)

        {
            PlayerGender[0].SetActive(true);
            PlayerGender[1].SetActive(false);
        }
        else if (gender == 2)
        {
            PlayerGender[0].SetActive(false);
            PlayerGender[1].SetActive(true);

        }
        SkinColors.SetActive(true);
    }
    
    
    public void EditGender()
    {
        currentGender = PlayerPrefs.GetInt("Gender"); 

        if (currentGender == 1)

        {
            PlayerGender[0].SetActive(true);
            PlayerGender[1].SetActive(false);
        }
        else if (currentGender == 2)
        {
            PlayerGender[0].SetActive(false);
            PlayerGender[1].SetActive(true);

        }
        SkinColors.SetActive(true);
    }
    

    public void goCrator()
    {
        if (currentGender != 0)//De�er ald��� durum.
        {
            UIpanels[1].SetActive(false);//CharacterGenderSelect
            UIpanels[2].SetActive(true);//CaracterCratorPanels
        }
    }
    public void goEditCrator()
    {
        if (currentGender != 0)//De�er ald��� durum.
        {
            UIpanels[5].SetActive(false);//CharacterSelect
            UIpanels[2].SetActive(true);//CaracterCratorPanels
            UIpanels[8].SetActive(true);//CaracterCratorPanels
            UIpanels[7].SetActive(false);//CaracterCratorPanels

        }
    }


    public void goCharacterSelect()
    {
        UIpanels[0].SetActive(false);//Main Panel
        UIpanels[2].SetActive(false);//CaracterCratorPanels
        UIpanels[5].SetActive(true);//CharacterSelect
    }
    public void goMainMenu()
    {
        UIpanels[2].SetActive(false);//CaracterCratorPanels
        UIpanels[0].SetActive(true);//Main Panel
        UIpanels[5].SetActive(false);//CharacterSelect
 
    }
    public void BackSelect()
    {
            UIpanels[1].SetActive(true);
            UIpanels[2].SetActive(false);
    }



    public void Costume()
    {
        if (currentGender == 1)//Male
        {
            for (int i = 0; i < MalePanels.Length; i++)
            {
                if (i == 1)
                {
                    MalePanels[i].SetActive(true);
                }
                else
                {
                    MalePanels[i].SetActive(false);
                }

            }
        }
        else if (currentGender == 2)
        {
            for (int i = 0; i < FemalePanels.Length; i++)
            {
                if (i == 1)
                {
                    FemalePanels[i].SetActive(true);
                }
                else
                {
                    FemalePanels[i].SetActive(false);
                }

            }
        }
    }
    public void Face()
    {
        if (currentGender == 1)//Male
        {
            for (int i = 0; i < MalePanels.Length; i++)
            {
                if (i == 0)
                {
                    MalePanels[i].SetActive(true);
                }
                else
                {
                    MalePanels[i].SetActive(false);
                }

            }
        }
        else if (currentGender == 2)
        {
            for (int i = 0; i < FemalePanels.Length; i++)
            {
                if (i == 0)
                {
                    FemalePanels[i].SetActive(true);
                }
                else
                {
                    FemalePanels[i].SetActive(false);
                }

            }
        }
    } 
    public void Accessories()
    {
        if (currentGender == 1)//Male
        {
            for (int i = 0; i < MalePanels.Length; i++)
            {
                if (i == 2)
                {
                    MalePanels[i].SetActive(true);
                }
                else
                {
                    MalePanels[i].SetActive(false);
                }

            }
        }
        else if (currentGender == 2)
        {
            for (int i = 0; i < FemalePanels.Length; i++)
            {
                if (i == 2)
                {
                    FemalePanels[i].SetActive(true);
                }
                else
                {
                    FemalePanels[i].SetActive(false);
                }

            }
        }
    }


    public void NextScene()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void MainScane()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
