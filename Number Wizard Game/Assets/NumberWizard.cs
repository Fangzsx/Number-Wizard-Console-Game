using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard Game!");
        Debug.Log("Please pick a number from the following");
        Debug.Log("Highest number you can pick is " + max);
        Debug.Log("Lowest number possible is " + min);
        Debug.Log("Tell me if your number is higher or lower than 500.");
        Debug.Log("Push up = Higher, Push down = Lower, Push Enter = Correct");


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow was pressed!");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow was pressed!");
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed!");
        }
    }
}
