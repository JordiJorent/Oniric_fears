using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public string scenename;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(waitForProgram());
        }
    }
    IEnumerator waitForProgram()
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(LoadAsyncScene());
    }

    IEnumerator LoadAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scenename);
        asyncLoad.allowSceneActivation = false;
        yield return (asyncLoad.progress > 0.9f);
        StartCoroutine(loaded(asyncLoad));
    }

    IEnumerator loaded(AsyncOperation sync)
    {
        yield return new WaitForSeconds(1);
        sync.allowSceneActivation = true;
    }
}
