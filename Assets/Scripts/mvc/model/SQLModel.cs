using System.Collections.Generic;

namespace mvc.model
{
    [System.Serializable]
    public class SQLData
    {
        public int index; // The index of the SQL command and table data
        public string query; // The correct SQL query
        public string tableData; // The table data to be displayed as text (optional)
        public string tableImage; // The path to the image to be displayed

        public SQLData(int index, string query, string tableData, string tableImage)
        {
            this.index = index;
            this.query = query;
            this.tableData = tableData;
            this.tableImage = tableImage;
        }
    }

    [System.Serializable]
    public class SQLModel
    {
        public List<SQLData> sqlDataList = new List<SQLData>();
    }
}
