using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaneSelectGender : MonoBehaviour
{


    public GameObject malePrefab;
    public GameObject femalePrefab;

    void Start()
    {
        int gender = PlayerPrefs.GetInt("Gender");
        Debug.Log(gender);

        if (gender == 1)
        {
            GameObject.Instantiate(malePrefab);
        }
        else if (gender == 2)
        {
            GameObject.Instantiate(femalePrefab);
        }
    }


}
