

////////////////////////////// DA BI RADILO MORAMO PRVO DA STARTUJEMO TextAPIservice PROJEKAT //////////////////////////////
///
////////////////////////////// APLIKACIJA JE NAPRAVLJENJA KROZ SWITCH CASE I WFC SERVICE //////////////////////////////

using System.IO;
using System;
using UserText.DatabaseQy;
using System.Collections.Generic;
using System.Text;
using API.service;
using System.Data.SqlClient;

namespace UserText.TextReaderMain
{

    class Program
    {
        static async Task Main(string[] args)
        {
            ////////////////////////////////////CONNECTION STRING/////////////////////////////////////////////////////

            var datasource = @"DESKTOP-D3T79NK\SQLEXPRESS";

            var database = "Task_AM";

            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connString);

            ////////////////////////////////////CONNECTION STRING/////////////////////////////////////////////////////

            ServiceClient obj = new ServiceClient();

            string Options;

            Console.WriteLine("Choose an option: 1 - file ; 2 - database ; 3 - add text");

            Options = Convert.ToString(Console.ReadLine());

            switch (Options.ToLower())
            {
                case "1": ////////////////////////////// CITANJE IZ FAJLA //////////////////////////////
                    try
                    {
                        string filePath = "Sample.txt";

                        List<string> textLines = new List<string>();

                        textLines = File.ReadAllLines(filePath).ToList();

                        StringBuilder sb1 = new StringBuilder();

                        foreach (string line in textLines)
                        {
                            Console.WriteLine(line);

                            sb1.Append(line + Environment.NewLine);
                        }
                        var result = await obj.GetDataAsync(sb1.ToString());

                        Console.WriteLine(result);
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    break;

                case "2": ////////////////////////////// CITANJE IZ BAZE, GDE IMAMO DVA SLUCAJA, SAMO CITANJE I INSERT PODATKA PA ONDA CITANJE ///////////////////////////////

                    String chooseAction;

                    Console.WriteLine("Choose an option: a - select rows from table, b - insert row into table");

                    chooseAction = Convert.ToString(Console.ReadLine());

                    switch (chooseAction.ToLower()) 
                    {
                        case "a": ////////////////////////////// CITANJE IZ BAZE //////////////////////////////
                            try
                            {
                                DatabaseQuery daQy = new DatabaseQuery();
                                
                                var result = daQy.Select("SELECT * FROM UserText", connString);

                                Console.WriteLine(await obj.GetDataAsync(result));

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exception: " + e.Message);
                            }
                        break;

                        case "b": ////////////////////////////// INSERT PA ONDA CITANJE //////////////////////////////
                            try
                            {
                                DatabaseQuery daQy = new DatabaseQuery();

                                Console.WriteLine("Enter text for insert below:");

                                var userText2 = Convert.ToString(Console.ReadLine());

                                daQy.Insert(userText2, connString);

                                Console.WriteLine("You have successfully inserted text!");

                                var result = daQy.Select("SELECT * FROM UserText", connString);

                                Console.WriteLine(await obj.GetDataAsync(result));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exception: " + e.Message);
                            }
                        break;

                        default:
                        Console.WriteLine("Invalid option has been chosen. Ending session.");
                        break;
                    }
                break;

                case "3": ////////////////////////////// UNETI TEKST PA CITANJE //////////////////////////////a
                    try
                    {
                        Console.WriteLine("Write your own text:");

                        StringBuilder sb3 = new StringBuilder();

                        Console.WriteLine();

                        var userText3 = Convert.ToString(Console.ReadLine());

                        sb3.Append(userText3);

                        var result = await obj.GetDataAsync(sb3.ToString());

                        Console.WriteLine(result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                break;

                default:

                Console.WriteLine("Invalid option has been chosen. Ending session.");

                break;
            }
        }


    }


}

