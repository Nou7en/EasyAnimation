using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        // Destruir el enemigo (este objeto) cuando colisiona con cualquier objeto
        Destroy(gameObject);
    }
}
