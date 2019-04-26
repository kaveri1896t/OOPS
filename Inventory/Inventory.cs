// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inventory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.Inventory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Inventory to print data read from java script object notation file
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// this method read inventory details from java script object notation file
        /// and display it.
        /// </summary>
        public void PrintTotalData()
        {
            try
            {
                //// Reads the file 
                Inventory inventoryDetails = new Inventory();

                ////Instance of the File path to get json fule path
                FilePaths filePath = new FilePaths();

                ////creating list of type inventory structure to store read data into list
                List<InventoryStructure> items = inventoryDetails.ReadFile(filePath.InventoryProducts);

                ////Print the data format
                Console.WriteLine("Name\t\tWeight\t\tPricePerKg\tTotalAmount");
                foreach (var item in items)
                {
                    ////Print the details with total cost
                    Console.WriteLine("{0}" + "\t\t" + "{1}" + "\t\t" + "{2}" + "\t\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.PricePerKg * item.Weight);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Reads the file into variable.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>Returns inventory details read from file</returns>
        public List<InventoryStructure> ReadFile(string fileName)
        {
            ////StreamReader is  used to read from the file
            using (StreamReader reader = new StreamReader(fileName))
            {
                ////Read into json till end of the file
                var json = reader.ReadToEnd();

                //// deserialize data (convert between json data to .Net type)
                var items = JsonConvert.DeserializeObject<List<InventoryStructure>>(json);
                return items;
            }
        }
    }
}