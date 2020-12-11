using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{
    public GameObject m_target;
    private MathsHelpers m_mathHelper = new MathsHelpers();
    private void Update()
    {

        Vector3 direction = m_target.transform.position.normalized;

        transform.LookAt(direction * Time.deltaTime, Vector3.up);
    }
    
}
