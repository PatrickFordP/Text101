using UnityEngine;

[CreateAssetMenu(menuName = nameof(State))]
public class State : ScriptableObject
{
    [TextArea(15,20)]
    [SerializeField] 
    private string storyText;

    [SerializeField]
    private State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
