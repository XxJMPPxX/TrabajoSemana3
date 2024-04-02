using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class VidaPersonaje : MonoBehaviour
{
    public int color;
    public int vida = 10;
    private SpriteRenderer spriteRenderer;
    public static int lifewaaa;
    public UnityEvent OnHeartTouched;
    public bool TocastePuerta;
    public UnityEvent OnTouchDoorNext;
    public UnityEvent OnTouchDoorWin;




    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    public void rojo()
    {
        spriteRenderer.color = Color.red;
        color = 1;
    }
    public void azul()
    {
        spriteRenderer.color = Color.blue;
        color = 2;
    }
    public void amarillo()
    {
        spriteRenderer.color = Color.yellow;
        color = 3;
    }






    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("Amarillo"))
        {
            if (color == 3)
            {

            }
            else
            {
                vida = vida - 2;
                Debug.Log("-2");

            }
        }
        if (collision.CompareTag("Azul"))
        {
            if (color == 2)
            {

            }
            else
            {
                vida = vida - 2;
                Debug.Log("-2");

            }
        }
        if (collision.CompareTag("Rojo"))
        {
            if (color == 1)
            {

            }
            else
            {
                vida = vida - 2;
                Debug.Log("-2");

            }
        }

        if (collision.CompareTag("Life"))
        {


            OnHeartTouched.Invoke();


        }
        


        if (collision.CompareTag("Marron1"))
        {



            OnTouchDoorNext.Invoke();

        }
        if (collision.CompareTag("Marron2"))
        {
            OnTouchDoorWin.Invoke();
        }
        

    }


    public void CambioDeEscena()
    {


        SceneManager.LoadScene("Perdio");


    }
   

   


}
    



    





