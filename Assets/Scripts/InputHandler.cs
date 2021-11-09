using UnityEngine;
using Commands;

public class InputHandler
{
    private Command _buttonA;
    private Command _buttonD;
    private Command _buttonSpace;
    private Command _buttonQ;

    public void SetCommandA(Command command)
    {
        _buttonA = command;
    }

    public void SetCommandD(Command command)
    {
        _buttonD = command;
    }

    public void SetCommandSpace(Command command)
    {
        _buttonSpace = command;
    }

    public void SetCommandQ(Command command)
    {
        _buttonQ = command;
    }

    public Command handleInput()
    {
        if (Input.GetKeyDown(KeyCode.A)) return _buttonA;
        if (Input.GetKeyDown(KeyCode.D)) return _buttonD;
        if (Input.GetKeyDown(KeyCode.Space)) return _buttonSpace;
        if (Input.GetKeyDown(KeyCode.Q)) return _buttonQ;
        return null;
    }
}
