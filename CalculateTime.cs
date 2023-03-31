using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    internal class CalculateTime
    {
        public void FindTime(string name, int noofofficers, string other_candidates)
        {

            other_candidates += " " + name;
            string total_candidates_list = other_candidates;

            List<string> candidatesListInAlphabetOrder = total_candidates_list.Split().ToList<string>();

            candidatesListInAlphabetOrder.Sort();

            int user_token_number = candidatesListInAlphabetOrder.IndexOf(name);
            int total_time = 20 * (user_token_number / noofofficers + 1);
            Console.WriteLine("The total time taken to get license : {0}",total_time);

        }
    }
}
