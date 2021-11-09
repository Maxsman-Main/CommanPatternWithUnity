using UnityEngine;
using Commands;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private Player actor;
    private InputHandler inputHandler;

    private void Start()
    {
        inputHandler = new InputHandler();
        inputHandler.SetCommandA(new MoveLeftCommand());
        inputHandler.SetCommandD(new MoveRightCommand());
        inputHandler.SetCommandSpace(new JumpCommand());
        inputHandler.SetCommandQ(new AttackCommand());
    }

    private void Update()
    {
        Command command = inputHandler.handleInput();
        if (command != null)
        {
            command.Execute(actor);
        }
    }
}
