using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    private SpriteRenderer mySpriteRenderer;
    public Animator animator;


   // This function is called just one time by Unity the moment the component loads
   private void Awake()
   {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
   }
    // Start is called before the first frame update
    
    
    
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
            mySpriteRenderer.flipX = false;
            Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
            if( Input.GetAxis("Horizontal") < 0) {
                mySpriteRenderer.flipX = true;
            }

            animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"), 0.0f, 0.0f);
            transform.position = transform.position + horizontal * Time.deltaTime;
    }
}
