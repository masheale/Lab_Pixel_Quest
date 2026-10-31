
using UnityEngine;
using UnityEngine.SceneManagement;

public class WORLD : MonoBehaviour
{

    private Rigidbody2D Rb;
    private SpriteRenderer _Spriterender;
    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        _Spriterender = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        Rb.velocity = new Vector2(xinput * speed, Rb.velocity.y);

       if(xinput > 0){ _Spriterender.flipX = true; }
            else if (xinput < 0) { _Spriterender.flipX = false; }
    }




    public string nextlevel = "physics #2 1";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }


            case "Finish":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
        }

    }

    private Rigidbody2D rb;
    public int colorChangeSpeed = 5;


    
}

