using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackVisitant : MonoBehaviour
{
    public GameObject attackPrefab;
    public KeyCode AttackKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(AttackKey))
        {
            var prefabPosition = new Vector3(transform.position.x, transform.position.y + 0.25f, transform.position.z - 1);

            Instantiate(attackPrefab, prefabPosition, attackPrefab.transform.rotation);
        }
    }
}