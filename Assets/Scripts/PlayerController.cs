using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed; //Скорость персонажа
    private Rigidbody2D rb; //Для столкновения персонажа с другими объектами
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Указываем чему равняется переменная rb
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //Смещение перснажа (raw для плавности)
        moveVelocity = moveInput.normalized * PlayerSpeed; //Высчитывает какая клавиша нажата, приводит  в движение персонажа
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime); //Пока кнопка нажата действие повторяется
    }
}
