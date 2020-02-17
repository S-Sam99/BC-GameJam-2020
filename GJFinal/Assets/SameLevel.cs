using UnityEngine;
using UnityEngine.SceneManagement;

public class SameLevel : MonoBehaviour
{

    public Animator animator;

    private int levelToLoad;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel(SceneManager.GetActiveScene().buildIndex);
        }


    }

    public void FadeToNext()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);

    }
}
