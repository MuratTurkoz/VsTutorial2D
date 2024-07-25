using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCoroutineScript : MonoBehaviour
{
    // Coroutine method
    public IEnumerator MoveOverTime()
    {
        // 2 saniye bekle
        yield return new WaitForSeconds(1.5f);

        gameObject.SetActive(false);
       
    }
}
