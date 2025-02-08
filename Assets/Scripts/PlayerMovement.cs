using UnityEngine;
namespace AG1922
{ 
public class PlayerMovement : MonoBehaviour
 {
    public float speed = 2.0f;
    private Rigidbody2D body;
    private bool _isOnGround;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        _isOnGround = false;
    }
    private void Update()
    {
      
        body.linearVelocityX = Input.GetAxis("Horizontal") * speed;
        
        
        if (Input.GetKey(KeyCode.Space) && _isOnGround)
        {
                body.linearVelocityY = speed;
                _isOnGround = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Items"))
        {
            Debug.Log("Hit the ground or items");
            _isOnGround = true;
        }
    }


 }
}
