using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float invokeTime = 1f;
    [SerializeField] ParticleSystem finishEffect;
    bool hasFinished = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !hasFinished)
        {
            hasFinished = true;
            FindAnyObjectByType<PlayerController>().DisableControl();
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", invokeTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
