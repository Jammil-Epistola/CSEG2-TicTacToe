using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public Placing placing;
    public bool ended;
    public string result;
    public GameObject endScreen;
    public Text resultText;

    public void Start() 
    {
        ended = false;
        endScreen.SetActive(false);
    }

    public void Check() 
    {   
        //PLAYER 1 WINNING CONDITIONS
        // HORIZONTAL WIN
        if (placing._holder[0] == 0 && placing._holder[1] == 0 && placing._holder[2] == 0) 
        {
            ended = true;
            result = "Player 1 Wins!";
            for(int i = 0; i < 9 ; i++) 
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[3] == 0 && placing._holder[4] == 0 && placing._holder[5] == 0)
        {
            ended = true;
            result = "Player 1 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[6] == 0 && placing._holder[7] == 0 && placing._holder[8] == 0)
        {
            ended = true;
            result = "Player 1 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        // VERTICAL WIN
        else if (placing._holder[0] == 0 && placing._holder[3] == 0 && placing._holder[6] == 0)
        {
            ended = true;
            result = "Player 1 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[1] == 0 && placing._holder[4] == 0 && placing._holder[7] == 0)
        {
            ended = true;
            result = "Player 1 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[2] == 0 && placing._holder[5] == 0 && placing._holder[8] == 0)
        {
            ended = true;
            result = "Player 1 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        //DIAGONAL WIN
        else if (placing._holder[0] == 0 && placing._holder[4] == 0 && placing._holder[8] == 0)
        {
            ended = true;
            result = "Player 1 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[2] == 0 && placing._holder[4] == 0 && placing._holder[6] == 0)
        {
            ended = true;
            result = "Player 1 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }

        //PLAYER 2 WINNING CONDITIONS
        // HORIZONTAL WIN
        if (placing._holder[0] == 1 && placing._holder[1] == 1 && placing._holder[2] == 1)
        {
            ended = true;
            result = "Player 2 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[3] == 1 && placing._holder[4] == 1 && placing._holder[5] == 1)
        {
            ended = true;
            result = "Player 2 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[6] == 1 && placing._holder[7] == 1 && placing._holder[8] == 1)
        {
            ended = true;
            result = "Player 2 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        // VERTICAL WIN
        else if (placing._holder[0] == 1 && placing._holder[3] == 1 && placing._holder[6] == 1)
        {
            ended = true;
            result = "Player 2 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[1] == 1 && placing._holder[4] == 1 && placing._holder[7] == 1)
        {
            ended = true;
            result = "Player 2 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[2] == 1 && placing._holder[5] == 1 && placing._holder[8] == 1)
        {
            ended = true;
            result = "Player 2 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        //DIAGONAL WIN
        else if (placing._holder[0] == 1 && placing._holder[4] == 1 && placing._holder[8] == 1)
        {
            ended = true;
            result = "Player 1 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[2] == 1 && placing._holder[4] == 1 && placing._holder[6] == 1)
        {
            ended = true;
            result = "Player 2 Wins!";
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else 
        {
            if (placing.move == 9) 
            {
                result = "Draw";
                ended = true;
                for (int i = 0; i < 9; i++)
                {
                    placing.interactable[i] = false;
                }
            }
        }

        if (ended == true) 
        {
            endScreen.SetActive(true);
            resultText.text = result;
            placing.turnText.gameObject.SetActive(false);
        }
    }

}
