using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDamageScript : MonoBehaviour
{
    private Animator animator;
    [SerializeField]
    private GameObject bigStone;
    [SerializeField]
    private int objectHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player_Ship")
        {
            objectHealth -= 23;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (objectHealth < 0)
        {
            StartCoroutine(BoomStart());
            //iets waardoor er dingen spawnen
        }
    }

    private IEnumerator BoomStart()
    {
        animator.SetTrigger("Boom");
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

}
