using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed = 0.5F;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private SpawnManagerX spawnManagerXScript;
    
    void Start()
    { 
        playerGoal = GameObject.Find("Player Goal");
        enemyRb = GetComponent<Rigidbody>();
        spawnManagerXScript = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
        speed = spawnManagerXScript.enemySpeed;
    }
    
    void Update()
    {
      
        Vector3 ObjectiveDirection = (playerGoal.transform.position - transform.position).normalized;
        
        enemyRb.AddForce(ObjectiveDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
            Debug.Log("Enemy score");
        }

       if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
            Debug.Log("Goal!");
        }
    }

}
