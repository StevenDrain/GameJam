using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public GameObject CartridgeEjectObj;
    public GameObject bullet;
    public Transform firePoint;
    public GameObject Enemy;

    public Transform cartridgePoint;
    private float bulletForce = 1000f;

    private float cartridgeForce = 250f;
    
    public GameObject bulletClone;

    private GameObject CartridgeEjectClone;

    //firespeed stuff
    public float fireRate = 0.2f;
    private bool canFire = true;

    public void Start(){
        
        
    }
    /// <summary>
    /// This method is called every frame to update the state of the gun.
    /// </summary>
    public void Update()
    {
        
        if (Input.GetMouseButton(0) && canFire == true)
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
        Destroy(bulletClone, 10f);
    }
    public void CartridgeEject(){
        CartridgeEjectClone = Instantiate(CartridgeEjectObj, cartridgePoint.position, cartridgePoint.rotation);
        Rigidbody rb = CartridgeEjectClone.GetComponent<Rigidbody>();
        rb.AddForce(cartridgePoint.up * cartridgeForce);
        rb.AddForce(-cartridgePoint.forward * cartridgeForce);
        Destroy(CartridgeEjectClone, 2f);
        
        CartridgeEjectClone.transform.Rotate(20000f * Time.deltaTime, 20000f * Time.deltaTime, 20000f * Time.deltaTime);

    }
   
    
}
