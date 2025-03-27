using UnityEngine;

public class Cat : MonoBehaviour
{
    // Private properties (not visible in Inspector)
    private string favoriteToy = "Ball of Yarn";
    private int age = 3;

    // Public properties (visible in Inspector)
    public string catName = "Whiskers";
    public float speed = 5f;

    void Start()
    {
        Debug.Log($"The cat {catName} is {age} years old and loves its {favoriteToy}.");
    }

    void Update()
    {
        /*Denne kan kun bevæge sig til højre og venstre.    Time.deltaTime gør at bevægelsen uafhæning af framerate
         * 
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move, 0f, 0f);
        */

        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(moveX, moveY, 0f);
    }
}
