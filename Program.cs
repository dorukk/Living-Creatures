livingcreatures animals = new livingcreatures();

            animals.data = "Animals ara wierd!";
            animals.year = 12;
            Console.WriteLine(animals.year);
            livingcreatures plants = new livingcreatures();

            Console.WriteLine(animals.data);

            plants.data = "Plants are strange!";
            Console.WriteLine(  plants.GetType());
            Console.WriteLine(plants.data);
            Console.ReadKey();
