using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour
{
        public Text hullDisplay;

    void Start()
        {

            hullDisplay = GetComponent<Text>();

        StaticVariables.playerHealth = 100;
        }

        void Update()
        {
            if (StaticVariables.playerHealth < 0)
            StaticVariables.playerHealth = 0;

            hullDisplay.text = "Hull Integrity: " + StaticVariables.playerHealth;
        }
}
