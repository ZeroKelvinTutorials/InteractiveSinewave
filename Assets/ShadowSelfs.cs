using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowSelfs : MonoBehaviour
{

    public static bool shadowing = false;
    Coroutine shadowingCoroutine;
    void Start()
    {
        // StartCoroutine(MakeShadowSelf(.5f));
    }
    void Update()
    {
        if(shadowing == true && shadowingCoroutine == null)
        {
            shadowingCoroutine = StartCoroutine(MakeShadowSelf(.5f));
        }
    }
    IEnumerator MakeShadowSelf(float period)
    {
        while(shadowing)
        {
            Instantiate(Resources.Load("Shadow") as GameObject, this.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(period);
        }
        shadowingCoroutine = null;
        yield return null;
    }
}
