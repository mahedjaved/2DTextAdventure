using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class AdventureGame : MonoBehaviour
{
    // UNITY editor global variables
    [SerializeField] Text text;

    // your starting state is the main-menu title
    [SerializeField] SO_State startingState;


    // VS global variables
    SO_State state;
      
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        text.text = startingState.getStoryState();
      
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    // this function allows us to cycle through the states
    private void ManageState()
    {
        var nextStates = state.GetNextStates();
    }
}
