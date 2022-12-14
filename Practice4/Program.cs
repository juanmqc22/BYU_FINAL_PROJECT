
/// *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
/// Author: Juan Quezada
/// Project of BYU
/// EXERCISE 4
/// *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
using System;
namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity activity = new Activity();
            activity.Creating_Activity("");
            Running running_1 = new Running();
            running_1.Creating_Activity("Running");
            Swimming swimming_1 = new Swimming();
            swimming_1.Creating_Activity("Swimming");
            Cycling cycling_1 = new Cycling();
            cycling_1.Creating_Activity("Cycling");
        }
    }
    class Activity
    {
        public int lenght = 0;
        public int minutes = 0;
        public string date = "";
        public int speed = 0;
        public int pace = 0;
        public int distance = 0;
        string get_random(List<string> array)
        {
            var random = new Random();
            int randIndex = random.Next(array.Count);
            return array[randIndex];
        }
        int get_random_number()
        {
            var random = new Random();
            return random.Next(100);
        }
        public void Set_length()
        {
            lenght = get_random_number();
        }
        public void Set_minutes()
        {
            minutes = get_random_number();
        }
        public void Set_pace()
        {
            pace = get_random_number();
        }
        public void Set_distance()
        {
            distance = get_random_number();
        }
        public void Set_speed()
        {
            speed = get_random_number();
        }
        public void Set_date()
        {
            date = RandomDay();
        }
        public Activity Creating_Activity(string act)
        {
            Activity activity = new Activity();
            activity.Set_length();
            activity.Set_minutes();
            activity.Set_date();
            activity.Set_distance();
            activity.Set_pace();
            activity.Set_speed();
            activity.display(act);
            return activity;
        }
        private Random gen = new Random();
        string RandomDay()
        {
            DateTime start = new DateTime(2018, 6, 15);
            return start.ToString("dd MMMM yyyy");
        }
        public virtual void display(string _activity)
        {
            Console.WriteLine($"\n * {date} {_activity} ({minutes} min): Distance {distance} Km, Speed {speed} kph, Pace {pace} min per km\n");
        }
    }

    class Running : Activity
    {
        public override void display(string _activity)
        {
            Console.WriteLine("*-*-*-*- Running! *-*-*-*-*-*-");
            _activity = "Running";
            base.display(_activity);
        }
    }
    class Cycling : Activity
    {
        public override void display(string _activity)
        {
            Console.WriteLine("*-*-*-*- Cycling! *-*-*-*-*-*-");
            _activity = "Cycling ";
            base.display(_activity);
        }
    }
    class Swimming : Activity
    {
        public override void display(string _activity)
        {
            Console.WriteLine("*-*-*-*- Swimming! *-*-*-*-*-*-");
            _activity = "Swimming";
            base.display(_activity);
        }
    }

}
