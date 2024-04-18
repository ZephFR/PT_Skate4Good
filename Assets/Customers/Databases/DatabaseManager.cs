using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomersOrdersDB", menuName = "Database/Customers", order = 0)]

public class DatabaseManager : ScriptableObject
{
    public List<RequestData> datas = new();
    
    public void CreateData()
    {
        if (datas.Exists(data => data.name == "Jack"))
            return;

        RequestData newCustomer = new(
            name: "Jack",
            order: "Je veux la planche la plus stylée du game",
            Wheels: RequestData.WheelsChoices.Cruiser,
            Board: RequestData.BoardChoices.Popscicle,
            Grip: RequestData.GripChoices.Stars);
            

        datas.Add(newCustomer);
    }
}
