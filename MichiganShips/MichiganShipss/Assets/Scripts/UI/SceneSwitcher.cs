public class SceneSwitcher : UnityEngine.MonoBehaviour
{
    public static string previousLoser { get; set; }
    
    static int fightScene = 1;
    static int menuScene = 0;
    static int restartScene = 2;

    public void StartGame()
    {
        SceneSwitcher.SwitchFight();
    }

    public void MainMenu()
    {
        SceneSwitcher.SwitchMenu();
    }

    public static void SwitchFight()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(fightScene);
    }

    public static void SwitchMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(menuScene);
    }

    public static void SwitchRestart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(restartScene);
    }

}
