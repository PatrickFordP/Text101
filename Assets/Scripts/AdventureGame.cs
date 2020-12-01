using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] 
    private Text textComponent;

    [SerializeField]
    private State startingState;

    private State _state;

    private State state
    {
        get => _state;
        set
        {
            _state = value;
            textComponent.text = _state.GetStateStory();
        }
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        state = startingState;
    }

    // Update is called once per frame
    private void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for( int index = 0; index < nextStates.Length; index++)
        {
            if( Input.GetKeyDown( KeyCode.Alpha1 + index ) )
            {
                state = nextStates[index];
            }
        }
    }
}
