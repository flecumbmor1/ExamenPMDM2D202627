using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public CheckGround checkGround;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody;
    private Animator _animator;
    private bool _jumpRequesed; 

    // Start is called before the first frame update
    void Start()
    {
        /* Sabiendo la función de este método
        genere las instrucciones necesarias...
        */
        _rigidBody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) /*&& EnemyController.checkGround()*/){
        _jumpRequesed=true;
        }
    }

    void FixedUpdate()
    {
        checkMove();
    }

    private void checkMove()
    {
         if (Mathf.Abs(_rigidBody.velocity.x) > 0.01f)
        {
            _animator.SetBool("isRunning",true);
        }
        else
        {
            _animator.SetBool("isRunning",false);
        }
        if (Input.GetKey(KeyCode.A)){
        _rigidBody.velocity= new Vector2 (-speed, _rigidBody.velocity.y);
       if (_spriteRenderer.flipX is false)
                {
                    _spriteRenderer.flipX = true;
                }
    }
    else if (Input.GetKey(KeyCode.D)){
         _rigidBody.velocity= new Vector2 (speed, _rigidBody.velocity.y);
    }
        /* Genere el código para que el jugador se mueva...
        añada las animaciones pertinentes
        */
         if (_spriteRenderer.flipX is true)
                {
                    _spriteRenderer.flipX = false;
                }

        
    }    
    
    private void checkJump()
    {
        _rigidBody.velocity= new Vector2 (speed,jumpForce);
        _jumpRequesed = false;
        /* Genere el código para que el jugador salte...
        añada las animaciones pertinentes
        */
    }

    public void impulse(float impulse)
    {
        /*
        Este método se ejecutará cuando el jugador salte sobre 
        la cabeza del enemigo impulsado al jugador hacia arriba.
        */

    }



}