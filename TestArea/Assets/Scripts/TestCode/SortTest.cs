using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var products = new List<Product> { new Product("IDNAME1", "name2", 12.9m),
                                           new Product("IDNAME2", "name3", 9.9m),
                                           new Product("IDNAME3", "name1", 14.9m),
        };

        Debug.Log("before sorting");
        foreach(var p in products)
        {
            Debug.Log("name: " + p.Name);
        }
        products.Sort((x, y) => x.Name.CompareTo(y.Name));
        Debug.Log("after sorting");
        foreach (var p in products)
        {
            Debug.Log("name: " + p.Name);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Product
{
    readonly string idName;
    public string IdName { get { return idName; } }
    public string Name { get; private set; }
    public decimal? Price { get; private set; }

    // Constructor
    public Product(string idnam, string name, decimal? price)
    {
        idName = idnam;
        Name = name;
        Price = price;
    }

    // Try some stuff
    public void TrySomeStuff()
    {
        //idName = "name";
    }

}
