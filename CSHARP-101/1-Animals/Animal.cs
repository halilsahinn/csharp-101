namespace _1_Animals
{
    public class Animal
    {
        public string Name
        {
            get => default;
            set
            {
            }
        }

        public int Weight
        {
            get => default;
            set
            {
            }
        }

        public int Age
        {
            get => default;
            set
            {
            }
        }

        public virtual void getDosage()
        {
            throw new System.NotImplementedException();
        }

        public virtual void getFeedSchedule()
        {
            throw new System.NotImplementedException();
        }
    }
}