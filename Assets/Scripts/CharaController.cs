using UnityEngine;

public class CharaController : MonoBehaviour
{
    private CharacterController _characterController;
    private Animator _anim;
    [SerializeField] private float _speed;

    private void Start() 
    {
        _characterController = GetComponent<CharacterController>();    
        _anim = GetComponent<Animator>();
    }

    private void Update() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(moveHorizontal, 0f, 0f);

        if(move != Vector3.zero)
        {
            _characterController.Move(move * _speed * Time.deltaTime);
            _anim.SetBool("isMoving", true);
        }
        else
        {
            _anim.SetBool("isMoving", false);
        }
        
    }
}
