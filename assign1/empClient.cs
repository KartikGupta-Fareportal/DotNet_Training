using System;

namespace emp{
    class Program{
        public static void Main(){
            Permanent p1 = new Permanent();
            p1.getDetails();
            p1.showDetails();

            Trainee t1 = new Trainee();
            t1.getTraineeDetails();
            t1.showTraineeDetails();
        }
    }
}