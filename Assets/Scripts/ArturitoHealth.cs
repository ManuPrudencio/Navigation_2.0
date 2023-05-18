using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArturitoHealth : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(Muerte());
        }
    }
    IEnumerator Muerte()
    {
        this.animator.SetTrigger("Die");
        yield return  new WaitForSeconds(0.8f);
        SceneManager.LoadScene("Game");
    }


}

        

    
