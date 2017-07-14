using UnityEngine;
using System.Collections.Generic;

namespace Data
{
    public class ReadSimpleCSV : MonoBehaviour
    {
        private void Awake()
        {
            ReadData();
        }

        private void ReadData()
        {
            string filePath = "simple_csv";
            try
            {
                List<Dictionary<string, object>> data = CSVReader.Read(filePath);
                for (int i = 0; i < data.Count; i++)
                {
                    Player player = new Player();
                    player.playerID = (int)data[i]["player_id"];
                    player.playerName = (string)data[i]["player_name"];
                    player.playerDescription = (string)data[i]["player_description"];

                    ///
                    PlayerParameter.Instance.SetPlayerParameter(player);
                }
            }
            catch (System.Exception)
            {
                Debug.LogError("File " + filePath + ".csv không tồn tại hoặc dữ liệu trong file không đúng định dạng.");
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
                throw;
            }
        }
    }
}
