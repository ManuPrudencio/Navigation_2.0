using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArturitoHealth : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    private Animator animator;

    private Canvas FinalCanvas;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        animator = GetComponent<Animator>();
        FinalCanvas = canvas.GetComponent<Canvas>();
        FinalCanvas.enabled = false;



    }

    // Update is called once per frame
    void Update()
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
        Time.timeScale = 0.0F;
        FinalCanvas.enabled = true;
        
        
    }


}

        

    
