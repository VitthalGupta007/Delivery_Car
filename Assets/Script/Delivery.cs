using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1); 
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1); 
    [SerializeField] float destorydelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // if (the thing we trigger is the package)
        //{
        //      then print "Package picked up" to the console
        // }
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destorydelay);
        }
        if (other.tag == "customer" && hasPackage)
        {
            Debug.Log("Package Deliverd");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
