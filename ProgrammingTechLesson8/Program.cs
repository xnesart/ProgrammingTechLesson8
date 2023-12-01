using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgrammingTechLesson8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ArrayList");
            ArrayList arrayList = new ArrayList();
            int val = 2;
            arrayList.Add(3.1);
            arrayList.Add(4.2);
            arrayList.Add(1.6);
            arrayList.Add(2.6);
            arrayList.Add(3.6);
            arrayList.Add(4.6);

            double index = arrayList.IndexOf(2.6);
            arrayList.Remove(3.1);
            bool inList = arrayList.Contains(4.2);
            foreach (var value in arrayList)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(index);
            Console.WriteLine(inList);
            /////////////////////////////
            Console.WriteLine("Очередь Queue");
            Queue queue = new Queue();
            queue.Enqueue(23.6);
            queue.Enqueue(11.5);
            queue.Enqueue(10.3);
            queue.Enqueue(9.4);
            queue.Dequeue();
            bool contains = queue.Contains(23.6);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(contains);
            /////////////////////////////
            Hashtable hashtable = new Hashtable();

            AddToHashTable(hashtable, "вася", 5.4);
            AddToHashTable(hashtable, "петя", 3.4);
            AddToHashTable(hashtable, "олег", 2.4);
            AddToHashTable(hashtable, "вася", 5.6);
            Console.WriteLine("Hashtable содержит:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }


            try
            {
                // Вызов метода для вычисления среднего и обнуления значений
                CalculateAndZeroArrayList(ref arrayList);
                CalculateAndZeroQueue(ref queue);
                CalculateAndZeroHashTable(ref hashtable);

                // Вывод обновленных коллекций
                Console.WriteLine("Обновленные коллекции:");
                Console.WriteLine("ArrayList:");
                foreach (var value in arrayList)
                {
                    Console.WriteLine(value);
                }

                Console.WriteLine("Queue:");
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Hastable:");
                foreach (DictionaryEntry entry in hashtable)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошло исключение: {ex.Message}");
            }

            //Часть 2
            Stack<string> stack = new Stack<string>();
            string staples = "(())(()";
            stack = StaplesCheck(staples);
            if (stack.Count != 0)
            {
                Console.WriteLine("Последовательность скобок неверна");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine("Последовательность скобок правильная");
            }
            
            //часть 3
            ArrayList arrayWithStudents = new ArrayList();
            Student student1 = new Student("вася", "федоров", 1, 4, 4, 5);
            Student student2 = new Student("петя", "иванов", 2, 4, 4, 5);
            Student student3 = new Student("иван", "максимов", 3, 3, 3, 3);
            Student student4 = new Student("олег", "ясенев", 4, 4, 3, 5);
            Student student5 = new Student("семен", "федоров", 2, 3, 3, 3);
            Student student6 = new Student("андрей", "петров", 2, 4, 4, 4);
            Student student7 = new Student("дима", "соколов", 1, 3, 3, 5);
            Student student8 = new Student("даня", "сергеев", 3, 3, 5, 5);
            Student student9 = new Student("владислав", "миронцев", 1, 4, 4, 4);
            Student student10 = new Student("владимир", "князев", 4, 5, 5, 5);
            arrayWithStudents.Add(student1);
            arrayWithStudents.Add(student2);
            arrayWithStudents.Add(student3);
            arrayWithStudents.Add(student4);
            arrayWithStudents.Add(student5);
            arrayWithStudents.Add(student6);
            arrayWithStudents.Add(student7);
            arrayWithStudents.Add(student8);
            arrayWithStudents.Add(student9);
            arrayWithStudents.Add(student10);
            
            Queue<Student> queueOfStudents = new Queue<Student>();
            queueOfStudents.Enqueue(student1);
            queueOfStudents.Enqueue(student2);
            queueOfStudents.Enqueue(student3);
            queueOfStudents.Enqueue(student4);
            queueOfStudents.Enqueue(student5);
            queueOfStudents.Enqueue(student6);
            queueOfStudents.Enqueue(student7);
            queueOfStudents.Enqueue(student8);
            queueOfStudents.Enqueue(student9);
            queueOfStudents.Enqueue(student10);
            
            Console.WriteLine("Вывод худшего студента с помощью ArrayList");
            FindMinScoreOfStudentsArray(arrayWithStudents);
            Console.WriteLine("Вывод худшего студента с помощью Queue");
            FindMinScoreOfQueueOfStudents(queueOfStudents);
        }

        public static bool AddToHashTable(Hashtable hashtable, string key, double value)
        {
            try
            {
                hashtable.Add(key, value);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Произошло исключение: {ex.Message}");
            }

            if (hashtable.ContainsKey(key) && hashtable.ContainsValue(value))
            {
                return true;
            }

            return false;
        }

        public static ArrayList CalculateAndZeroArrayList(ref ArrayList collection)
        {
            double sum = 0;

            foreach (var item in collection)
            {
                if (item is double)
                {
                    sum += (double)item;
                }
            }

            double average = 0;
            average = sum / collection.Count;
            ArrayList updatedCollection = new ArrayList();
            foreach (var item in collection)
            {
                if (item is double && (double)item < average)
                {
                    updatedCollection.Add(0);
                }
                else
                {
                    updatedCollection.Add(item);
                }
            }

            Console.WriteLine($"среднее арифметическое в ArrayList = {average}");
            collection = updatedCollection;
            return updatedCollection;
        }

        public static Queue CalculateAndZeroQueue(ref Queue collection)
        {
            double sum = 0;

            foreach (var item in collection)
            {
                if (item is double)
                {
                    sum += (double)item;
                }
            }

            double average = 0;
            average = sum / collection.Count;
            Queue updatedCollection = new Queue();
            foreach (var item in collection)
            {
                if (item is double && (double)item < average)
                {
                    updatedCollection.Enqueue(0);
                }
                else
                {
                    updatedCollection.Enqueue(item);
                }
            }

            Console.WriteLine($"среднее арифметическое в Queue = {average}");
            collection = updatedCollection;
            return updatedCollection;
        }

        public static Hashtable CalculateAndZeroHashTable(ref Hashtable collection)
        {
            double sum = 0;
            double[] arrValues = new double[collection.Count];
            string[] arrKeys = new String[collection.Count];
            int counter = 0;
            foreach (DictionaryEntry item in collection)
            {
                if (item.Value is double)
                {
                    sum += (double)item.Value;
                    arrValues[counter] = (double)item.Value;
                    arrKeys[counter] = (string)item.Key;
                    counter++;
                }
            }

            double average = 0;
            average = sum / collection.Count;
            Hashtable updatedCollection = new Hashtable();
            counter = 0;
            while (counter < collection.Count)
            {
                if (arrValues[counter] is double && (double)arrValues[counter] < average)
                {
                    updatedCollection.Add(arrKeys[counter], 0);
                }
                else
                {
                    updatedCollection.Add(arrKeys[counter], arrValues[counter]);
                }

                counter++;
            }
            
            Console.WriteLine($"среднее арифметическое в HashTable = {average}");
            collection = updatedCollection;
            return updatedCollection;
        }

        public static Stack<string> StaplesCheck(string staples)
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < staples.Length; i++)
            {
                if (staples[i].ToString() == "(")
                {
                    stack.Push(staples[i].ToString());
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"стэк пуст, ошибка {e}");
                    }
                }
            }

            return stack;
        }

        public static void FindMinScoreOfStudentsArray(ArrayList arrayList)
        {
            int minScore = 0;
            string name = "";
            string surname = "";
            foreach (Student student in arrayList)
            {
                if (student.Course == 2)
                {
                    minScore = student.ScoreSum;
                    name = student.Name;
                    surname = student.Surname;
                    break;
                }
            }

            if (name == "")
            {
                Console.WriteLine("студентов второго курса нет");
                return;
            }

            foreach (Student student in arrayList)
            {
                if (student.Course == 2)
                {
                    if (minScore > student.ScoreSum)
                    {
                        name = student.Name;
                        surname = student.Surname;
                        minScore = student.ScoreSum;
                    }
                }
            }

            Console.WriteLine($"худшая успеваемость у студента {name} {surname} {minScore}");
        }

        public static void FindMinScoreOfQueueOfStudents(Queue<Student> queue)
        {
            int minScore = 0;
            string name = "";
            string surname = "";
            foreach (Student student in queue)
            {
                if (student.Course == 2)
                {
                    minScore = student.ScoreSum;
                    name = student.Name;
                    surname = student.Surname;
                    break;
                }
            }

            if (name == "")
            {
                Console.WriteLine("студентов второго курса нет");
                return;
            }

            foreach (Student student in queue)
            {
                if (student.Course == 2)
                {
                    if (minScore > student.ScoreSum)
                    {
                        name = student.Name;
                        surname = student.Surname;
                        minScore = student.ScoreSum;
                    }
                }
            }

            Console.WriteLine($"худшая успеваемость у студента {name} {surname} {minScore}");
        }
    }
}