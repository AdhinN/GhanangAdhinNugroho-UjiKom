using UnityEditor.Build.Content;
using UnityEngine;

public class Deer : MonoBehaviour
{
    private int _hunger = 200;
    private int _score = 1;

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
    }
}
