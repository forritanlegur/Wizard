using UnityEngine;
using System.Collections;
using TMPro;

public class WizardName : MonoBehaviour
{
    Wizard firstWizard = new Wizard();

    void Start()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText(firstWizard.name);
    }

    //------------------Wizard class----------------------------------------
    class Wizard
    {
        public string name;
        public int age;
        public string magicType;

        //Wizard names
        private static string[] nameList =
        {
            "Gandalf",
            "Frodo",
            "Magnus",
            "Durin",
            "Regin",
            "Vitr",
            "Augmund",
            "Eilif"
        };

        //Wizard titles
        private static string[] titleList =
        {
            "Elder",
            "Zealot",
            "Grand Master",
            "Cleric",
            "Archdruid",
            "Archmage",
            "Sorcerer"
        };

        //Wizard Magic types
        private static string[] magicList =
        {
            "Eldritch",
            "Druidic",
            "Arcane",
            "Healing",
            "Cursed",
            "Grey",
            "Brave",
            "Celestial",
            "Wise"
        };

        //the Wizard constructor
        public Wizard()
        {
            //Random stuff
            var rnd = new System.Random();
            int nameRnd = rnd.Next(0, nameList.Length);
            int titleRnd = rnd.Next(0, titleList.Length);
            int magicRnd = rnd.Next(0, magicList.Length);
            int ageRnd = rnd.Next(18, 999);

            this.age = ageRnd;
            this.name =
                titleList[titleRnd]
                + " "
                + nameList[nameRnd]
                + " the "
                + magicList[magicRnd]
                + " Wizard";
            this.magicType = magicList[magicRnd];
        }
    }
}
//--------------------------------------------------------------------
