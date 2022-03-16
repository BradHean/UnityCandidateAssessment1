using UnityEngine;
using UnityEngine.InputSystem;

public class MoveAndTurn : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float turnSpeed;

    private Vector2 move;
    private Vector2 turn;
    private Vector3 euler;

    private void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null) return;
        //move
        move = gamepad.leftStick.ReadValue();
        transform.Translate(new Vector3(move.x, 0, move.y) * moveSpeed * Time.deltaTime);

        //turn
        turn = gamepad.rightStick.ReadValue();
        euler = transform.localEulerAngles;
        euler.y += turn.x * turnSpeed * Time.deltaTime;
        transform.localEulerAngles = euler;
    }

}
