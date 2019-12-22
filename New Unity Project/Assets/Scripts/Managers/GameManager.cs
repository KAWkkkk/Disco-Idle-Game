using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float startingBalance;
    public float currentBalance;

    public GameObject entrancePoint;

    public UpgradeManager upgradeManager;
    public UpgradeMenu upgradeMenu;

    // Start is called before the first frame update
    void Start()
    {
        currentBalance = startingBalance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Visitor"))
        {
            currentBalance += upgradeMenu.chosenPrice;
            Debug.Log("Visitor Entered Disco");
        }
    }
}
