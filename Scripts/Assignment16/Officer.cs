using UnityEngine;
namespace Assignment16
{
    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position)
        {
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Debug.Log("Officer");
        }
    }
}