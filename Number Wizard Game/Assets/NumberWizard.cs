using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {

        


        Debug.Log("Welcome to Number Wizard Game!");
        Debug.Log("Please pick a number from the following");
        Debug.Log("Highest number you can pick is " + max);
        Debug.Log("Lowest number possible is " + min);
        Debug.Log("Tell me if your number is higher or lower than 500.");
        Debug.Log("Push up/ W key = Higher, Push down/ W key = Lower, Push Enter = Correct");


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Up arrow/W key was pressed!");
            min = guess;
            Debug.Log(guess);

        }

        else if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Down arrow/S key was pressed!");
            max = guess;
            Debug.Log(guess);
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed!");
        }



    }
}
