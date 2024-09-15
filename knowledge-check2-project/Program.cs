namespace knowledge_check2_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many bats do you want to add? "); // How many rows in DB
            var numberOfRecords = int.Parse(Console.ReadLine()); // Collecting user input on rows


            var recordList = new List<Bat>(); // Creating a new list of type glove
            for (int i = 0; i < numberOfRecords; i++) 
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var bat = new Bat();

                bat.EquipmentID = i + 1;
                Console.WriteLine("Enter Name of Equipment:");
                bat.EquipmentName = Console.ReadLine();

                Console.WriteLine("Style of Bat:");
                bat.Style = Console.ReadLine();
                recordList.Add(bat);
            }

            Console.WriteLine("Products Entered:");
            foreach(var bat in recordList)
            {
                Console.WriteLine(bat.ToString());
            }
        }

        
    }
}
