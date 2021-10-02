public class SceneSwitcher : UnityEngine.MonoBehaviour
{
    public int sceneToSwitchTo = 0;

    public void OnSceneSwitch()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToSwitchTo);
    }
}
