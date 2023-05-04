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
        dialog.dialog.sent.Add(new Dialog.Sentences("Оуджи. Джа джа укради жареную огогуш рыба. Шо лолито шакалы."));
        dialog.dialog.sent.Add(new Dialog.Sentences("Да уж, тут у тебя и правда рыбу не половишь... ", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("Нимо зида?"));
        dialog.dialog.sent.Add(new Dialog.Sentences("Зида-зида... Жди, короче. Скоро вернусь с  рыбой. — Устало пообещал Этан.", true));
    }
    public void FishQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Будь, как дома, мой эхо сламма джамма. "));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ты. Построишь. Мне. Башню. Ты же уже понимаешь меня, верно?", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ох, мой эхо сламма джамма, языковый барьер так силен... "));
        dialog.dialog.sent.Add(new Dialog.Sentences("Я тебя абсолютно, совсем-совсем не сойки оля-ля."));
        dialog.dialog.sent.Add(new Dialog.Sentences("Я бы мог воринта тебе примерный дикпикто моего языка, " +
            "но для этого кусаки сейки перо. Гама перо — и мы скидыщ бам-бам."));

    }
    public void FeatherQuestDone()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("End");
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Держи свое перо. Доволен? Теперь-то ты начнешь строить башню?! " +
            "— Рассердился капибара.", true));
        dialog.dialog.sent.Add(new Dialog.Sentences("Отличная джоба, мой сламма джамма. Сейчас я воринта тебе дикпикто."));
        dialog.dialog.sent.Add(new Dialog.Sentences("Рептилия погрузила перо в чернильницу, сделала несколько отметок и передала рукопись млекопитающему. " +
            "— Держи, вот он — мой дикпикто."));
        dialog.dialog.sent.Add(new Dialog.Sentences("Ага. Новых слов почти нет. Ты же уже понимал мою просьбу? " +
            "Тогда на кой черт я искал перо?! — Царь перешел на крик.", true)); ;
        dialog.dialog.sent.Add(new Dialog.Sentences("Я просто был уверен, что перо ты не достанешь. " +
            "Но раз уж ты смог, то я помогу тебе достроить башню, Царь-Капибара! Вперед."));
    }

    public void TreasureQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Чен очучи рыба. Че-е-ен очучи!"));
        dialog.dialog.sent.Add(new Dialog.Sentences("Кажется, он хвастается.", true));
        isTreasureDone = true;
    }
    public void CartQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Нини чоно! Совсем нини очучи чоно!"));
        dialog.dialog.sent.Add(new Dialog.Sentences("Кажется, он крайне раздосадован чем-то.", true));
        isCartDone = true;
    }
    public void GiftQuestProcess()
    {
        if (isCartDone && isTreasureDone)
        {
            dialog.dialog.Clear();
            dialog.dialog.sent.Add(new Dialog.Sentences("Очень очучи рыбы больше нет. Чинчан весь сгорел! " +
                "Хлеба больше не чао-бао! Как же быть..."));
            dialog.dialog.sent.Add(new Dialog.Sentences("В чем дело, уважаемые?", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("О, цица капибара! У нас у всех завтра день рождения, " +
                "но с недавних пор у нас совсем нет подар..."));
            dialog.dialog.sent.Add(new Dialog.Sentences("Стой, у вас всех день рождения в один день?", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("Щиде, мы все братья, чонги."));
            dialog.dialog.sent.Add(new Dialog.Sentences("Большая семейка...", true));
            dialog.dialog.sent.Add(new Dialog.Sentences("Ну так ты бангджу нам? Нужен подарок, который порадует все джатинь."));
            dialog.dialog.sent.Add(new Dialog.Sentences("Хорошо, я поищу.", true));
        }        
    }
    public void GiftQuestDone()
    {
        dialog.dialog.Clear();
        dialog.dialog.sent.Add(new Dialog.Sentences("Спасибо, это именно то, что мы хотели! — Хором провыло племя шакалов. " +
            "— Отметь с нами. Завтра мы присоединимся к постройке Чуда Света."));
    }
}
