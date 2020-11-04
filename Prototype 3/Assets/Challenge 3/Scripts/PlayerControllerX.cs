using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce = 5f;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip bounceSound;

    private float isTooHigh = 12f;
    private bool isLowEnough = true;
    public bool isOnGround = true;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * floatForce, ForceMode.Impulse);
        isLowEnough = true;
    }
    void Update()
    {
        if (transform.position.y > isTooHigh)
        {
            isLowEnough = false;
        }
        // While space is pressed and player is low enough, float up
        else if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            isLowEnough = true;
            playerRb.AddForce(Vector3.up * floatForce,ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if player collides with bomb, explode and set gameOver to true
         if (collision.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(collision.gameObject);
        } 

        // if player collides with money, fireworks
        else if (collision.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(collision.gameObject);
        }
         else if (collision.gameObject.CompareTag("Ground") && ! gameOver)
                 {
                     playerAudio.PlayOneShot(bounceSound, 1f);
                     playerRb.AddForce(Vector3.up * floatForce,ForceMode.Impulse);
                 }
    }

}
