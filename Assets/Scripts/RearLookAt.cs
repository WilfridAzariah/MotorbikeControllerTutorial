using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearLookAt : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 position;

	void Update () {

        Vector3 dist = transform.localPosition - target.localPosition;
        Quaternion rot = Quaternion.LookRotation(dist + position);
        transform.localRotation = rot;
	}
}
