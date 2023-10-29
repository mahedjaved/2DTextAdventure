using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make it accessible to Asset Menu
[CreateAssetMenu(menuName = "SO_State")]


public class SO_State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string StoryText;
    [SerializeField] SO_State[] nextStates;

    public string getStoryState() 
    {
        return StoryText;
    }

    // all my methods
    public SO_State[] GetNextStates()
    {
        return nextStates;
    }

}
