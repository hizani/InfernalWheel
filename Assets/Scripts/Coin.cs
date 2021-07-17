using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(50 * Time.deltaTime, 0, 0) ;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerManager.numberOfCoins++;
            Destroy(gameObject);
            Debug.Log("Coins: " + PlayerManager.numberOfCoins);
        }
    }

}
