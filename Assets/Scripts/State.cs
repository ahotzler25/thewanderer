using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

// Class type is ScriptableObject so it doesn't need to be attached to a GameObject
public class State : ScriptableObject
{
    [SerializeField] State[] nextStates;

    [TextArea(20, 10)] [SerializeField] string storyText;

    public string GetStateStory() {
        return this.storyText;
    }

    public State[] GetNextState() {
        return nextStates;
    }
}