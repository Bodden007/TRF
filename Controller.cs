using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRF.Models;

namespace TRF
{
    internal class Controller
    {
        //NOTE write down your catalog
        public string directory { get; set; } = "C:\\Users\\h253747\\Desktop\\display\\CCD";
        public async Task Run()
        {

            ReadingThree readingThree = new ReadingThree();

            //NOTE TASK #1
            Console.WriteLine("Task #1");
            Console.WriteLine();
            var task_1 = await Task.Run(() =>
            readingThree.ReadFile(@"C:\\Users\\h253747\\Desktop\\display\\CCD\\README.txt"));

            var task_2 = await Task.Run(() =>
            readingThree.ReadFile(@"C:\\Users\\h253747\\Desktop\\display\\CCD\\REcirc Density.txt"));

            var task_3 = await Task.Run(() =>
            readingThree.ReadFile(@"C:\\Users\\h253747\\Desktop\\display\\CCD\\redmi.txt"));

            Console.WriteLine(task_1);
            Console.WriteLine("---------------");
            Console.WriteLine(task_2);
            Console.WriteLine("---------------");
            Console.WriteLine(task_3);
            Console.WriteLine("+++++++++++++++");
            Console.WriteLine();

            //NOTE TASK #2
            Console.WriteLine("Task #2");
            Console.WriteLine();
            FindFiles findFiles = new FindFiles();

            List<string> foundFiles = new List<string>();

            foundFiles = findFiles.Run(directory);

            var numArray = foundFiles.Count;

            int[] tasks = new int[numArray];

            for (int i = 0; i < numArray; i++)
            {
                tasks[i] = await Task.Run(() => readingThree.ReadFile(foundFiles[i]));
            }

            foreach (var item in tasks)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------");
            }
        }

    }
}
