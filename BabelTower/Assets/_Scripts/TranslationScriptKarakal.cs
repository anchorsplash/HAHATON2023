using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationScriptKarakal : MonoBehaviour
{
    public QuestManager manager;
    public DialogTrigger dialog;

    bool b = false;
    private void Update()
    {
        if (manager.isWellUsedCopy && b)
        {
            dialog.dialog.sentences[0] = "Здравствуй, плохие украсть жаренная вкусная рыба, это точно шакал";
            b = true;
        }
            
        if (manager.isFishUsed)
        {
            dialog.dialog.sentences[1] = "У голубь очень красиво перо";
        }
        if (manager.isFeatherUsed)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("End");
            dialog.dialog.sentences[2] = "Я очень рад, я помогу тебе";
        }
    }
}
