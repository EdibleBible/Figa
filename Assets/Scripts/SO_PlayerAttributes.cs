using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerAttributes", menuName = "PlayerAttributes")]

public class SO_PlayerAttributes : ScriptableObject
{
    public int player1Health;
    public int player1Damage;
    public int player1ShotSpeed;
    public int player1ShotInterval;
    public int player1Armor;

    public int player2Health;
    public int player2Damage;
    public int player2ShotSpeed;
    public int player2ShotInterval;
    public int player2Armor;

    public int moneyCollected;
}
