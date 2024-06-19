using UnityEngine;

public class Pizza : MonoBehaviour
{
    private int hungerValue = 25;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Deer"))
        {
            Deer deer = other.gameObject.GetComponent<Deer>();
            
        }    
    }
}
