using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCoroutine : MonoBehaviour
{
    public IEnumerator OverTime()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}
