using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Pupil : Person
    {
        //private int grade;
        private List<Activity> lstActivities;
        private char[] tabEval;


        public int Grade
        {
            get;
            set;
        }

        public char[] TabEval
        {
            get
            {
                return tabEval;
            }

            set
            {
                tabEval = value;
            }
        }

        public List<Activity> LstActivities
        {
            get
            {
                return lstActivities;
            }

            set
            {
                lstActivities = value;
            }
        }


        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(string name, int age) : this(name, age, 1)
        {

        }

        public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }

        public void AddEvaluation(String title = null, char eval = 'S')
        {
            foreach(Activity activity in lstActivities)
            {
                if(activity.Title == title)
                {
                    TabEval[lstActivities.IndexOf(activity)] = eval;
                    break;
                }
            }

            var act = from activity in lstActivities where activity.Title == title select activity;


        }

        public override string ToString()
        {

            String ch = base.ToString();
            int cptAct = LstActivities.Count();
            if(cptAct == 0)
            {
                ch += " n'as pas encore choisi d'activité";
            } else
            {
                ch += " a choisi les activitées suivantes : ";
                foreach(Activity activity in lstActivities){
                    ch += activity.ToString();
                }
            }
            return ch;
        }
    }
}
