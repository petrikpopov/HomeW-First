using UnityEngine;

public class TriangeScript : MonoBehaviour
{
     private Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("TriangleScript Starts");
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 forceDirection = Vector2.zero;
      
        // Движение по стрелкам
        if (Input.GetKey(KeyCode.UpArrow))
        {
            forceDirection += Vector2.up;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            forceDirection += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            forceDirection += Vector2.right;
        }
        
        // Добавление силы к объекту
        if (forceDirection != Vector2.zero)
        {
            rb2d.AddForce(forceDirection * 12);
        }     
        
        // Сброс силы при нажатии на ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rb2d.linearVelocity = Vector2.zero;
            rb2d.angularVelocity = 0f;
            Debug.Log("Сила сброшена");
        }
    }
}
