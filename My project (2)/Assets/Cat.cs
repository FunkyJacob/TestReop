using UnityEngine;

public class Cat : MonoBehaviour
{
    public  string name = "Ghost Cat";
    public string message = "Boo";
    private int value = 1;

    private void OnTriggerEnter2D(Collider2D collision) {
     //   Player.AddValue(value);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.cyan;
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempPosition = transform.position;
            tempPosition.x -= 1f * Time.deltaTime;
        transform.position = tempPosition;
    }
}
