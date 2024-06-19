using Unity.VisualScripting;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    private CharacterController _characterController;
    private Animator _anim;

    [SerializeField] private float _speed;
    [SerializeField] private float _speedShoot;
    [SerializeField] private GameObject _pizzaPrefab;

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

            if(move.x > 0f) //jalan ke kanan
            {
                _anim.SetBool("isRight", true);
            }
            else if(move.x < 0f) //jalan ke kiri
            {
                _anim.SetBool("isRight", false);
            }
        }
        else //idle
        {
            _anim.SetBool("isMoving", false);
        }

        if(Input.GetButtonDown("Fire1"))
        {
            TembakPizza();
        }
    }

    private void TembakPizza()
    {
        GameObject pizza = Instantiate(_pizzaPrefab, transform.position, transform.rotation);
        Rigidbody rb = pizza.GetComponent<Rigidbody>();

        rb.velocity = transform.forward * _speedShoot;

        Destroy(pizza, 3f);
    }
}
