using UnityEngine;
using System.Collections;

public class PlayerMenu : MonoBehaviour
{
    public GameObject StateMachine;
    public GameObject menuPref, buttonPref;

	// Use this for initialization
	void Start ()
    {
        StateMachine = GameObject.FindWithTag("StateMachine");
        StateMachine statemachine = StateMachine.GetComponent<StateMachine>();

            Debug.Log("in playermenu()");
             //8

            Instantiate(menuPref, new Vector3(-4, -3.5f), Quaternion.identity);
            for (int i = 0; i < 4; i++)
            {
                if (i < 2)
                {
                    float offSet1 = 0;
                    Instantiate(buttonPref, new Vector3(-5 + offSet1, -1), Quaternion.identity);
                    offSet1 += 3;
                }
                else if (i >= 2 && i < 4)
                {
                    float offSet1 = -3;
                    float offSet2 = 0;

                    Instantiate(buttonPref, new Vector3(-5 + offSet1, -1 + offSet2), Quaternion.identity);
                    offSet2 -= -3;
                }
            }

        Debug.Log("playermenu start()");
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
