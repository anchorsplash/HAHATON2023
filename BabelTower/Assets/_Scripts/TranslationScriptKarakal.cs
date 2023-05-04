using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationScriptKarakal : MonoBehaviour
{
    public DialogTrigger dialog;

    private bool isTreasureDone = false;
    private bool isCartDone = false;
    public void HandleQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч ќуджи. ƒжа джа укради жареную огогуш рыба. Ўо лолито шакалы."));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч ƒа уж, тут у теб€ и правда рыбу не половишь...†", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч Ќимо зида?"));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч «ида-зида... ∆ди, короче. —коро вернусь с  рыбой. Ч ”стало пообещал Ётан.", true));
    }
    public void FishQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч Ѕудь, как дома, мой эхо сламма джамма. "));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч “ы. ѕостроишь. ћне. Ѕашню. “ы же уже понимаешь мен€, верно?", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч ќх, мой эхо сламма джамма, €зыковый барьер так силен... "));
        dialog.dialog.sent.Add(new Dialog.Sentences("я теб€ абсолютно, совсем-совсем не сойки ол€-л€. я бы мог воринта тебе примерный дикпикто моего €зыка, " +
            "но дл€ этого кусаки сейки перо. √ама перо Ч и мы скидыщ бам-бам."));

    }
    public void FeatherQuestDone()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("End");
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("ƒержи свое перо. ƒоволен? “еперь-то ты начнешь строить башню?! " +
            "Ч –ассердилс€ капибара.", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч ќтлична€ джоба, мой сламма джамма. —ейчас € воринта тебе дикпикто."));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч –ептили€ погрузила перо в чернильницу, сделала несколько отметок и передала рукопись млекопитающему. " +
            "Ч†ƒержи, вот он Ч мой дикпикто."));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч јга. Ќовых слов почти нет. “ы же уже понимал мою просьбу? " +
            "“огда на кой черт € искал перо?! Ч ÷арь перешел на крик.", true)); ;
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч я просто был уверен, что перо ты не достанешь. " +
            "Ќо раз уж ты смог, то € помогу тебе достроить башню, ÷арь- апибара! ¬перед."));
    }

    public void TreasureQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч „ен очучи рыба. „е-е-ен очучи!"));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч  ажетс€, он хвастаетс€.", true));
        isTreasureDone = true;
    }
    public void CartQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч Ќини чоно! —овсем нини очучи чоно!"));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч  ажетс€, он крайне раздосадован чем-то.", true));
        isCartDone = true;
    }
    public void GiftQuestProcess()
    {
        if (isCartDone && isTreasureDone)
        {
            dialog.dialog.Clear();
            dialog.dialog.sent.Add(new Dialog.Sentences("Ч ќчень очучи рыбы больше нет. „инчан весь сгорел! " +
                "’леба больше не чао-бао!  ак же быть..."));
            dialog.dialog.sent.Add(new Dialog.Sentences("Ч ¬ чем дело, уважаемые?", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("Ч ќ, цица капибара! ” нас у всех завтра день рождени€, " +
                "но с недавних пор у нас совсем нет подар..."));
            dialog.dialog.sent.Add(new Dialog.Sentences("Ч —той, у вас всех день рождени€ в один день?", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("Ч ўиде, мы все брать€, чонги."));
            dialog.dialog.sent.Add(new Dialog.Sentences("Ч Ѕольша€ семейка...", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("Ч Ќу так ты бангджу нам? Ќужен подарок, который порадует все джатинь."));
            dialog.dialog.sent.Add(new Dialog.Sentences("Ч ’орошо, € поищу.", true));
        }        
    }
    public void GiftQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Ч —пасибо, это именно то, что мы хотели! Ч ’ором провыло плем€ шакалов. " +
            "Ч ќтметь с нами. «автра мы присоединимс€ к постройке „уда —вета."));
    }
}
