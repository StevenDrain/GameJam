using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public GameObject CartridgeEjectObj;
    public GameObject bullet;
    public Transform firePoint;

    public Transform cartridgePoint;
    private float bulletForce = 10000f;

    private float cartridgeForce = 250f;
    
    public GameObject bulletClone;

    private GameObject CartridgeEjectClone;

    //firespeed stuff
    public float fireRate = 0.5f;
    private bool canFire = true;

    public void Start(){
        
        
    }
    public void Update()
    {
        
        if (Input.GetButtonDown("Fire1") && canFire == true)
        {
            StartCoroutine(FireRate());
            
        }
        
        
       
        
    }
    IEnumerator FireRate()
    {
        Shoot();
        CartridgeEject();
        canFire = false;
        yield return new WaitForSeconds(fireRate);
        canFire = true;
    }
    public void Shoot()
    {
        bulletClone = Instantiate(bullet, firePoint.position, firePoint.rotation);
        Rigidbody rb = bulletClone.GetComponent<Rigidbody>();

        bulletClone.transform.rotation = Quaternion.Euler(90, 0, 0);

        rb.AddForce(firePoint.forward * bulletForce);
        Destroy(bulletClone, 100f);
    }
    public void CartridgeEject(){
        CartridgeEjectClone = Instantiate(CartridgeEjectObj, cartridgePoint.position, cartridgePoint.rotation);
        Rigidbody rb = CartridgeEjectClone.GetComponent<Rigidbody>();
        rb.AddForce(cartridgePoint.up * cartridgeForce);
        rb.AddForce(-cartridgePoint.forward * cartridgeForce);
        Destroy(CartridgeEjectClone, 2f);
        
        CartridgeEjectClone.transform.Rotate(20000f * Time.deltaTime, 20000f * Time.deltaTime, 20000f * Time.deltaTime);

    }
    public void rotateCartridge(){
        
    }
}
