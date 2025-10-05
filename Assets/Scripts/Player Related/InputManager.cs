using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputManager : MonoBehaviour
{
    //Utility
    private PlayerInput playerInput;
    private InputAction moveAction, lookAction, jumpAction, walkAction, crouchAction, TrickAction, LookAction, CameraAction;

    //Access
    public Vector2 MoveAxis {  get; private set; }
    public Vector2 CameraAxis { get; private set; }
    public bool Jump {  get; private set; }
    public bool Walk { get; private set; }
    public bool Crouch {  get; private set; }
    public bool Trick { get; private set; }
    public bool Look { get; private set; }

    private void Awake()
    {
        //Get references
        playerInput = GetComponent<PlayerInput>();

        //Set Up
        SetUpInputActions();
    }

    void Update()
    {
        UpdateInputs();
    }

    #region Behavior

    private void UpdateInputs()
    {
        MoveAxis = moveAction.ReadValue<Vector2>();
        CameraAxis = CameraAction.ReadValue<Vector2>();
        Jump = jumpAction.triggered;
        Walk = walkAction.IsPressed();
        Crouch = crouchAction.IsPressed();
        Trick = TrickAction.IsPressed();
        Look = LookAction.IsPressed();
    }

    #endregion

    #region Utility

    private void SetUpInputActions()
    {
        moveAction = playerInput.actions["Move"];
        lookAction = playerInput.actions["Look"];
        jumpAction = playerInput.actions["Jump"];
        walkAction = playerInput.actions["Walk"];
        crouchAction = playerInput.actions["Crouch"];
        TrickAction = playerInput.actions["Trick"];
        LookAction = playerInput.actions["Look"];
        CameraAction = playerInput.actions["Camera"];
    }

    #endregion
}
