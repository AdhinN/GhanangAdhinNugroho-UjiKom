using UnityEngine;

public class Dog : MonoBehaviour
{
    private int _hunger = 100;
    private int _score = 2;
    private float speed = 3;
    private Rigidbody rb;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    public void TakeDamage(int damage)
    {
        _hunger -= damage;
        if(_hunger <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        GameManager.instance.AddScore(_score);
        Destroy(gameObject);
    }
}
