// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommercialUtility.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.Commercial_Data_Processing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Utility for commercial data processing
    /// </summary>
    public class CommercialUtility
    {
        /// <summary>
        /// The file path object
        /// </summary>
        internal static FilePaths filePath = new FilePaths();

        /// <summary>
        /// Reads from file.
        /// </summary>
        /// <returns>List of CompanyShares</returns>
        public static List<CompanyShares> ReadFromFile()
        {
            CardsQueue.LinkedList1<CompanyShares> companysharesLinkedList = new CardsQueue.LinkedList1<CompanyShares>();
            if (File.Exists(filePath.CompanyShareFile))
            {
                string jsonData = File.ReadAllText(filePath.CompanyShareFile);

                ////Getting List<CompanyShares> object from JsonFile.
                List<CompanyShares> jsonObjectArray = JsonConvert.DeserializeObject<List<CompanyShares>>(jsonData);

                ////Adding All the CompanyShares Object to CustomLinkedLsit.
                foreach (CompanyShares cs in jsonObjectArray)
                {
                    companysharesLinkedList.AddLastIntoLinkedList(companysharesLinkedList, jsonObjectArray, cs);
                }

                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new List<CompanyShares>();
            }
        }

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="companySharesList">The company shares list.</param>
        public static void WriteToFile(List<CompanyShares> companySharesList)
        {
            //// Converting Object to JSon String.
            string jsonData = JsonConvert.SerializeObject(companySharesList);

            File.WriteAllText(filePath.CompanyShareFile, jsonData);
        }

        /// <summary>
        /// Reads the stock symbols.
        /// </summary>
        /// <returns>returns Stack</returns>
        public static Stack ReadStockSymbols()
        {
            Stack symbolStack = new Stack();
            symbolStack.StackInitialise(1000);

            ////Getting List Of StocksList
            List<CompanyShares> stocksList = ReadFromFile();

            //// Pushing all StockSymbol in Custom Stack.
            foreach (CompanyShares companyShares in stocksList)
            {
                symbolStack.Push(companyShares.Symbol);
            }

            return symbolStack;
        }

        /// <summary>
        /// Writes the symbol.
        /// </summary>
        /// <param name="symbolStack">The symbol stack.</param>
        public static void WriteSymbol(Stack symbolStack)
        {
            List<string> symbolList = new List<string>();
            while (!symbolStack.IsEmpty())
            {
                symbolList.Add(symbolStack.Pop());
            }

            string jsonData = JsonConvert.SerializeObject(symbolList);

            File.WriteAllText(filePath.CompanySharePurchasedFile, jsonData);
        }
    }
}
