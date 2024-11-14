using UnityEngine;
namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        Soldier soldier;
        Officer officer;
        Character[] characters = new Character[2];
        void Start()
        {
            soldier = new Soldier("Soldier", 100, new Position(1, 2, 3));
            officer = new Officer("Officer", 100, new Position(4, 5, 6));
            characters[0] = soldier;
            characters[1] = officer;
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }
            Debug.Log("Soldier Health: " + soldier.Health);
            officer.Attack(10, soldier, "kicking");
            Debug.Log("Soldier Health: " + soldier.Health);
        }
    }
}