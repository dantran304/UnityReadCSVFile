using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct Player
{
    public int playerID;
    public string playerName;
    public string playerDescription;
}

public class PlayerParameter : MonoBehaviour
{

    private List<Player> listPlayer = new List<Player>();

    public static PlayerParameter Instance;

    [SerializeField]
    private Text[] playerIDs;

    [SerializeField]
    private Text[] playerNames;

    [SerializeField]
    private Text[] playerDescription;

    [SerializeField]
    private int inputID;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        SetContent();
    }

    public void SetPlayerParameter(Player player)
    {
        int count = listPlayer.Count;
        if (count <= player.playerID)
        {
            listPlayer.Add(player);
        }
    }

    private void SetContent()
    {
        //for (int i = 0; i < listPlayer.Count; i++)
        //{
        //    playerIDs[i].text = listPlayer[i].playerID.ToString();
        //    playerNames[i].text = listPlayer[i].playerName.ToString();
        //    playerDescription[i].text = listPlayer[i].playerDescription.ToString();
        //}

        playerIDs[0].text = listPlayer[inputID].playerID.ToString();
        playerNames[0].text = listPlayer[inputID].playerName.ToString();
        playerDescription[0].text = listPlayer[inputID].playerDescription.ToString();
    }

}
