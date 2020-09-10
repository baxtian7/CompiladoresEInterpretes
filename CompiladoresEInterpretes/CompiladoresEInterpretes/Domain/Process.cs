using CompiladoresEInterpretes.DTO;
using System.Linq;

namespace CompiladoresEInterpretes.Domain
{
    public class Process
    {
        public ResultDTO Calculator(string name)
        {
            float percent = 1.7f;
            string lastName = "Perez";
            int count = 10;

            return new ResultDTO
            {
                NameBackwards = ChangeName(name, lastName),
                PercentName = PercentName(name, percent) + count
            };
        }

        private string ChangeName(string name, string lastName)
        {
            string fullName = $"{name} {lastName}";
            string nameBackwards = default;
            int countName = fullName.Count();
            char[] namerArray = fullName.ToCharArray();

            for (int i = countName; i > 0; i--)
            {
                nameBackwards += namerArray[i - 1].ToString();
            }
            return nameBackwards;
        }

        private float PercentName(string name, float percent)
        {
            int countName = name.Count();

            return countName * percent;
        }
    }
}
