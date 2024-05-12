using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// See klass määratleb mängu peamenüü käitumise.
public class MainMenu : MonoBehaviour
{
    // Meetod mängu alustamiseks. Kutsutakse esile, kui vajutatakse "Play" nuppu.
    public void PlayGame()
    {
        // Salvestab kasutaja viimase külastatud mängutüübi mängija eelistustesse
        PlayerPrefs.SetString("LastVisitedGame", "Game");
        // Laeb asünkroonselt "Game" stseeni, võimaldades sujuva ülemineku
        SceneManager.LoadSceneAsync("Game");
    }

    // Meetod mängu alustamiseks kallutusjuhtimisega. Kutsutakse esile, kui vajutatakse "Tilt" nuppu.
    public void PlayTiltGame()
    {
        // Salvestab kallutusjuhtimise mängurežiimi mängija eelistustesse tuleviku tarbeks
        PlayerPrefs.SetString("LastVisitedGame", "GameTilt");
        // Laeb asünkroonselt "GameTilt" stseeni, mis sisaldab kallutusjuhtimist
        SceneManager.LoadSceneAsync("GameTilt");
    }

    // Meetod mängust väljumiseks. Kutsutakse esile, kui vajutatakse "Quit" nuppu.
    public void QuitGame() {
        // Väljub rakendusest. Märkus: See toimib ainult päriselt füüsilises seadmes "ehitatud" mängus, mitte Unity redaktoris.
        Application.Quit();
    }
}
