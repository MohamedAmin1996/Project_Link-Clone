using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D enemy;
    private Animator animator;
    public int health = 2;
    public GameObject heart;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject getPlayer()
    {
        return player;
    }

    public Rigidbody2D getEnemyRB()
    {
        enemy = GetComponent<Rigidbody2D>();
        return enemy;
    }

    public void Knock(Rigidbody2D myRigidbody, float knockTime)
    {
        if(health > 0)
        {
            StartCoroutine(knockCo(myRigidbody, knockTime));
            health--;
        }
        else
        {
            Destroy(this.gameObject);
            if (Random.Range(0, 2) == 1)
            {
                Instantiate(heart, transform.position, Quaternion.identity);
            }
        }
        
    }

    private IEnumerator knockCo(Rigidbody2D myRigidbody, float knockTime)
    {
        if (myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            animator.SetBool("isWakingUp", false);
            myRigidbody.velocity = Vector2.zero;
        }
    }
}
