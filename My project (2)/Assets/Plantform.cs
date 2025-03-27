using UnityEngine;

public class Plantform : MonoBehaviour
{
    public float speed;
    public int startingPoint; // starting inder 
    public Transform[] points; // An array of transform points (position where the platform needs to move to)
    
    private int i; // intex of the arrey
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = points[startingPoint].position; // Setting the position of theplatform to 
                                                             // the position of one of the point using index "startingPoint"
    }

    // Update is called once per frame
    void Update()
    {
        // checking the distance of the platform and the point
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++; // increase the index 
            if (i == points.Length) // check if the platform was on the last point after the index increase
        }
    }

}
