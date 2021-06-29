using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{
    public Animator animator;
    [SerializeField]
    public float curHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth < 1)
        {
            StartCoroutine(BoomStart());
        }

    }

    private IEnumerator BoomStart()
    {
        animator.SetTrigger("SetBoom");
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       // if (other.gameObject.name == "Player_Ship")
       // {
       //     curHealth -= 20;
       // }

        if(other.gameObject.tag == "Laser")
        {
            curHealth -= 20;
        }
    }
}
