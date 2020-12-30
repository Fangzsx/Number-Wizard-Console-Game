using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {

        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Kamusta! Welcome to Number Guessing Game!");
        Debug.Log("Please pick a number from the following");
        Debug.Log("Highest number you can pick is " + max);
        Debug.Log("Lowest number possible is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up/ W key = Higher, Push down/ W key = Lower, Push Enter = Correct");

        max = max + 1;
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            
            //set the minimum value = guess
            min = guess;
            //change value of guess
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            max = guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I'm a genius!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
