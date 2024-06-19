using UnityEngine;

public class Deer : MonoBehaviour
{
    private int _hunger = 200;
    private int _score = 1;
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
