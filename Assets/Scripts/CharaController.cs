using UnityEngine;

public class CharaController : MonoBehaviour
{
    private CharacterController _characterController;
    [SerializeField] private float _speed;

    private void Start() 
    {
        _characterController = GetComponent<CharacterController>();    
    }

    private void Update() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(moveHorizontal, 0f, 0f);
        _characterController.Move(move * _speed * Time.deltaTime);    
    }
}
