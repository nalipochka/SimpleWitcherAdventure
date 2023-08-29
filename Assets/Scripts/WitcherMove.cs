using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WitcherMove : MonoBehaviour
{
    public int countCoin = 0;
    public Text countCoinText;

    //Rigidbody2D rb;
    //float speed = 60f;
    //float jumpPower = 2500f;

    //public int countCoin = 0;
    //public Text countCoinText;
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}


    //void Update()
    //{
    //    float right = Input.GetAxis("Horizontal");
    //    if (right != 0)
    //    {
    //        var position = transform.position;
    //        position += Vector3.right * right * Time.deltaTime * speed;
    //        rb.MovePosition(position);
    //    }
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        var position = transform.position;
    //        position += Vector3.up * Time.deltaTime * jumpPower;
    //        rb.MovePosition(position);
    //    }
    //}

    //Rigidbody2D rb;
    //public float speed;
    //public float jumpheight;
    //public Transform groundCheck;
    //bool isGrounded;
    //Animator anim;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}
    //void Update()
    //{
    //    Flip();
    //    CheckGround();
    //    rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    //    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    //        rb.AddForce(transform.up * jumpheight, ForceMode2D.Impulse);

    //}
    //void Flip()
    //{
    //    if (Input.GetAxis("Horizontal") > 0)
    //        transform.localRotation = Quaternion.Euler(0, 0, 0);
    //    if (Input.GetAxis("Horizontal") < 0)
    //        transform.localRotation = Quaternion.Euler(0, 180, 0);
    //}
    //void CheckGround()
    //{
    //    Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 1);
    //    isGrounded = colliders.Length > 1;
    //}

    //-----------------
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("WitcherCoin"))
        {
            countCoin++;
            Destroy(collision.gameObject);
            countCoinText.text = "Coin: " + countCoin.ToString(); 
        }
    }
    //-----------------


    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Flip();
        // Проверка на наличие контакта с землей (можно настроить свой способ определения)
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        // Движение
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        rb.velocity = movement;

        // Прыжок
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        rb.AddForce(Vector2.down * 10f);
    }

    void Flip()
    {
        if (Input.GetAxis("Horizontal") > 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetAxis("Horizontal") < 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
    }


}
