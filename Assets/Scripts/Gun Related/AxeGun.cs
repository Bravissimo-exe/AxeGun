using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeGun : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject axeGunPlayer;
    [SerializeField] private GameObject axeGunMonster;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(axeGunMonster);
            axeGunPlayer.SetActive(true);
        }
    }
}
