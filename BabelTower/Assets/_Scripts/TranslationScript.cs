using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationScript : MonoBehaviour
{
    public QuestManager manager;
    public DialogTrigger dialog;

    private void Update()
    {
        if (manager.isWellUsed)
        {
            Debug.Log("LLLL");
            dialog.dialog.sentences[0] = "Здравствуй, плохие украсть жаренная вкусная рыба, это точно шакал";
        }
            
        if (manager.isFishUsed)
        {
            dialog.dialog.sentences[1] = "У голубь очень красиво перо";
        }
        if (manager.isFeatherUsed)
        {
            dialog.dialog.sentences[2] = "Я очень рад, я помогу тебе";
        }
        if (manager.isCartInBurn)
            dialog.dialog.sentences[0] = "Интересно, что мне подарят на день рождения..";

        if (manager.isGiftUsed)
            dialog.dialog.sentences[1] = "Я очень рад, я помогу тебе";
    }
}
