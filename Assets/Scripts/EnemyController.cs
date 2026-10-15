using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float distanceFollow;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {        _rigidBody= GetComponent <Rigidbody2D>();
            _spriteRenderer= GetComponent <SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
       checkPlayerDistance();
        if (Mathf.Abs(_rigidBody.velocity.x) > 0.01f)
        {
            _animator.SetBool("isRunning",true);
        }
        else
        {
            _animator.SetBool("isRunning",false);
        }

    }

    void checkPlayerDistance()
    {
         if ( Vector2.Distance(transform.position, player.transform.position) < distanceFollow){
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position , speed * Time.deltaTime);
    }
        /*
        Este método checkea si el jugador está a menor distancia de la de
        distanceFollow, en tal caso seguirá al jugador.
        */
    }
    public void death()
    {

        
        /*
        Este método inicia la animación de death del enemigo
        */
    }

    public void destroyEnemy()
    {
        /*
        Este método destruye el objeto del enemigo
        */
    }


}
