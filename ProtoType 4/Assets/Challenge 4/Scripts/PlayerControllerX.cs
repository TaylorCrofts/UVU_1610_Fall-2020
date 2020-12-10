using System.Collections;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    private GameObject focalPoint;

    public float speedBoost=700f;
    public ParticleSystem boostParticle;

    public bool hasPowerup;
    public GameObject powerupIndicator;
    public int powerUpDuration = 5;

    private readonly float normalStrength = 5.0f; // how hard to hit enemy without powerup
    private readonly float powerupStrength = 25; // how hard to hit enemy with powerup

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    private void Update()
    {
        // Add force to player in direction of the focal point (and camera)
        var verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(focalPoint.transform.forward * speedBoost, ForceMode.Impulse);
            boostParticle.Play();
        }

        // Set powerup indicator position to beneath player
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.6f, 0);
    }
    
    
    // If Player collides with powerup, activate powerup
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            powerupIndicator.SetActive(true);
            Destroy(other.gameObject);
            //Call into action the couroutine process
            StartCoroutine(PowerupCooldown());
        }
    }

    // Coroutine to count down powerup duration
    private IEnumerator PowerupCooldown()
    {
        yield return new WaitForSeconds(powerUpDuration);
        hasPowerup = false;
        powerupIndicator.SetActive(false);
    }

    // If Player collides with enemy
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            var enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            var awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }

        else if (collision.gameObject.CompareTag("Enemy") && !hasPowerup)
        {
            var enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            var awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRigidbody.AddForce(awayFromPlayer * normalStrength, ForceMode.Impulse);
        }
    }
}
