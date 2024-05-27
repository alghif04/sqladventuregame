using UnityEngine;

// Add the following line to include the mvc.model namespace
using mvc.model;
using System.Data.SqlTypes;

public class SQLModelLoader : MonoBehaviour
{
    public SQLModel LoadSQLData(string filePath)
    {
        TextAsset jsonFile = Resources.Load<TextAsset>(filePath);
        string json = jsonFile.text;
        SQLModel model = JsonUtility.FromJson<SQLModel>("{\"sqlDataList\":" + json + "}");
        return model;
    }
}
