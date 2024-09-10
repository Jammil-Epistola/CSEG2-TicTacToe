using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingePlayer : MonoBehaviour
{
    public GameObject PopUp;

    public void Start()
    {
        PopUp.SetActive(false);
    }

    public void ShowPopUp() 
    {
        PopUp.SetActive(true);
    }

    public void ClosePopUp()
    {
        PopUp.SetActive(false);
    }

    public void URLlink() 
    {
        Application.OpenURL("https://www.youtube.com/watch?v=bv__9O5CZok");

    }

}
