using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraContrls : MonoBehaviour
{
    public Transform target;

    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
