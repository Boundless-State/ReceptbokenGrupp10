using System.Text.Json;

namespace ReceptbokenGrupp10.Classes
{
    public class Filehandler
    {
        ErrorLogger errorLogger;

        //string filePath = @"C:\Users\marcu\source\repos\ProgCSharp\ReceptbokenGrupp10\ReceptbokenGrupp10\ReceptbokenGrupp10\Resources\Recipes.json";
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\Recipes.Json");

        private readonly string _FilePath;

        public Filehandler()
        {
            errorLogger = new ErrorLogger();
          
        }
        public Filehandler(string filePath)
        {

            _FilePath = filePath;
            errorLogger = new ErrorLogger();
        }


        //Write to file
        public void WriteToFile(List<Recipe> recipes)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(recipes);

                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine(jsonString);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error writing to the JSON file: {ex.Message}");
                errorLogger.LogCustomError(ex);

            }


        }
        //Read all recepies
        public List<Recipe> ReadAllRecepies()
        {

            try
            {
                using (StreamReader Reader = new StreamReader(filePath))
                {
                    string jsonString = Reader.ReadToEnd();
                    return JsonSerializer.Deserialize<List<Recipe>>(jsonString);
                }


            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error reading from the JSON file: {ex.Message}");
                errorLogger.LogCustomError(ex);
                throw;

            }
        }
    }
}
