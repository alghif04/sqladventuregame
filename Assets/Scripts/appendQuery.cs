using UnityEngine;
using mvc.controller;
public class SQLCommandButtons : MonoBehaviour
{
    public SQLController sqlController;

    public void OnSelectButtonClick()
    {
        sqlController.AppendQuery("SELECT");
    }

    public void OnUpdateButtonClick()
    {
        sqlController.AppendQuery("UPDATE");
    }

    public void OnIncludeButtonClick()
    {
        sqlController.AppendQuery("INCLUDE");
    }

    public void OnWhereButtonClick()
    {
        sqlController.AppendQuery("WHERE");
    }

    public void OnAllButtonClick()
    {
        sqlController.AppendQuery("*");
    }

    public void OnInsertButtonClick()
    {
        sqlController.AppendQuery("INSERT");
    }

    public void OnCreateButtonClick()
    {
        sqlController.AppendQuery("CREATE");
    }

    public void OnFromButtonClick()
    {
        sqlController.AppendQuery("FROM");
    }

    public void OnGroupButtonClick()
    {
        sqlController.AppendQuery("GROUP");
    }

    public void OnDesaButtonClick()
    {
        sqlController.AppendQuery("DESA");
    }

    public void OnDropButtonClick()
    {
        sqlController.AppendQuery("DROP");
    }

    public void OnAlterButtonClick()
    {
        sqlController.AppendQuery("ALTER");
    }

    public void OnJoinButtonClick()
    {
        sqlController.AppendQuery("JOIN");
    }

    public void OnHavingButtonClick()
    {
        sqlController.AppendQuery("HAVING");
    }

    public void OnPendudukButtonClick()
    {
        sqlController.AppendQuery("PENDUDUK");
    }
}
