using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneScript : MonoBehaviour
{
    public static int LoadIndex;

    [SerializeField]
    private UnityEngine.UI.Image _prog;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation loadScene = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(LoadIndex);
        
        while(loadScene.progress<1)
        {
            _prog.fillAmount = loadScene.progress;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();

    }
}
