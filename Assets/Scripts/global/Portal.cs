using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Transform destination;

    public Transform GetDestination() {
        return destination;
    }

}
