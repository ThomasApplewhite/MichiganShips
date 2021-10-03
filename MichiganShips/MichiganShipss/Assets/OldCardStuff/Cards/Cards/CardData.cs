using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "ScriptableObjects/CardData", order = 1)]
public class CardData : ScriptableObject
{
    public string cardName;
    public string cardText;

    public int dubloonCost;
    public int dubloonGain;
    public int broadsides;
    public int deckGunShots;

    public System.Action specialEffect;
}