using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 10f;
    Vector3 movement;

  
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        movement = new Vector3(horizontalInput, 0f, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
