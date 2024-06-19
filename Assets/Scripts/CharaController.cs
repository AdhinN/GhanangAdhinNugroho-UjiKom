using Unity.VisualScripting;
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
            
            if(move.y > 0f) //jalan ke kanan
            {
                _anim.SetBool("isRight", true);
            }
            else if(move.y < 0f) //jalan ke kiri
            {
                _anim.SetBool("isMoving", true);
                _anim.SetBool("isRight", false);
            }
        }
        else //idle
        {
            _anim.SetBool("isMoving", false);
        }
        
    }
}
