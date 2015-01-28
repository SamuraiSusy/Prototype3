using UnityEngine;
using System.Collections;

public class StateMachine : MonoBehaviour
{

    public string[] battleStates = new string[] {  
        "Start",
        "PlayerMenu",
        "PlayerTurn",
        "EnemyTurn",
        "Win",
        "Lose",
        "Run"
                                                };
    public string currentState;

	// Use this for initialization
	void Start ()
    {
        currentState = "Start";
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (currentState == "Start")
            currentState = "PlayerMenu";
        else if(currentState == "PlayerMenu")
        {
        }
	}
}
