using UnityEngine;
using TMPro;
using mvc.model;

namespace mvc.controller
{
    public class SQLController : MonoBehaviour
    {
        public SQLModelLoader modelLoader;
        public SQLView view;
        private SQLModel model;
        private string currentQuery = "";

        [Tooltip("Specify the index of the SQL command and table data to use.")]
        public int index = 0; // Public field for specifying the index in the Inspector

        void Start()
        {
            model = modelLoader.LoadSQLData("mvc/model/SQLData");
            view.clearButton.onClick.AddListener(ClearQuery);
            view.submitButton.onClick.AddListener(SubmitQuery);
        }

        public void AppendQuery(string sqlCommand)
        {
            currentQuery += " " + sqlCommand;
            view.UpdateQueryWindow(currentQuery);
            CheckQuery();
        }

        void CheckQuery()
        {
            string correctQuery = model.sqlDataList[index].query.Trim();
            string currentQueryTrimmed = currentQuery.Trim();

            bool isCorrect = correctQuery == currentQueryTrimmed;
            view.SetSubmitButtonActive(isCorrect);

            if (isCorrect)
            {
                view.DisplayResult("Correct query!");
                view.DisplayTableImage(model.sqlDataList[index].tableImage);
            }
            else
            {
                view.DisplayResult("Incorrect query!");
                view.DisplayTableImage(null);
            }
        }

        void ClearQuery()
        {
            currentQuery = "";
            view.UpdateQueryWindow(currentQuery);
            view.SetSubmitButtonActive(false);
            view.DisplayResult("");
            view.DisplayTableImage(null);
        }

        void SubmitQuery()
        {
            CheckQuery();
        }
    }
}
