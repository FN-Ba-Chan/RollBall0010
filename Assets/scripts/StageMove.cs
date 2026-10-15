using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{
    private InputAction _playerInput;
    [SerializeField]
    private GameObject _stage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerInput = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
     //   Debug.Log(_playerInput.ReadValue<Vector2>());
        float horizontalInput = _playerInput.ReadValue<Vector2>().y;
        float verticalInput = _playerInput.ReadValue<Vector2>().x;
        //オブジェクトを回転させる
        //_stage.transform.Rotate(horizontalInput*0.1f,0f,verticalInput*-0.1f);
        //入力をVector3に変換
        Vector3 rotation = new Vector3(horizontalInput, 0f, verticalInput);
        //オイラー角に変換
        Quaternion tilt = Quaternion.Euler(rotation.x,0f, rotation.z); 
        //変換した値をRigidbodyに移す
        _stage.GetComponent<Rigidbody>().MoveRotation(_stage.GetComponent<Rigidbody>().transform.rotation * tilt);
    }
}
