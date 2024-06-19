using UnityEngine;

public class Pizza : MonoBehaviour
{
    private int _hungerValue = 25;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Deer"))
        {
            Deer deer = other.gameObject.GetComponent<Deer>();
            deer.TakeDamage(_hungerValue);
            Destroy(gameObject);
        } 

        if(other.gameObject.CompareTag("Cow"))
        {
            Cow cow = other.gameObject.GetComponent<Cow>();
            cow.TakeDamage(_hungerValue);
            Destroy(gameObject);
        } 

        if(other.gameObject.CompareTag("Horse"))
        {
            Horse horse = other.gameObject.GetComponent<Horse>();
            horse.TakeDamage(_hungerValue);
            Destroy(gameObject);
        } 

        if(other.gameObject.CompareTag("Dog"))
        {
            Dog dog = other.gameObject.GetComponent<Dog>();
            dog.TakeDamage(_hungerValue);
            Destroy(gameObject);
        } 
    }

}
