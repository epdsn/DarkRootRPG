using UnityEngine;

public class EntityState
{
    protected StateMachine stateMachine;

    protected string stateName;

    public EntityState(StateMachine stateMachine, string stateName)
    {
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter() {
        // every time we enter a state, reset the state's elapsed time
        Debug.Log($"Entering state: {stateName}");

    }
    public virtual void Update() {
        // this will be called every frame the state is active
        Debug.Log($"Updating state: {stateName}");
    }

    public virtual void Exit() {
        // this will be called when we exit the state
        Debug.Log($"Exiting state: {stateName}");

    }


}
