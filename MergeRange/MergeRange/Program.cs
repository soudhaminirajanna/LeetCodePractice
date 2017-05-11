using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeRange
{
    public class Loan
    {
        public string name;
        public int queryId;
    }

    public class query
    {
        public int id;
        public List<filter> filters;
    }
    public class filter : IComparable<filter>
    {
        public string type;
        public int value;

        public int CompareTo(filter other)
        {
            if (this.type == other.type)
            {
                return this.value.CompareTo(other.value);
            }
            else
            {
                return this.type.CompareTo(other.type);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


        }

        public static List<Loan> uniqueLoans(List<Loan> loans, List<query> queries)
        {
            List<Loan> result = new List<Loan>();
            HashSet<string> loanNameMap = new HashSet<string>();

            Dictionary<string, List<int>> filterMap = new Dictionary<string, List<int>>();

            foreach (var q in queries)
            {
                string filterText = "";
                q.filters.Sort();
                foreach (var f in q.filters)
                {
                    filterText = f.type + f.value;
                }
                if (filterMap.ContainsKey(filterText))
                {
                    filterMap[filterText].Add(q.id);
                }
                else
                {
                    filterMap.Add(filterText, new List<int>());
                    filterMap[filterText].Add(q.id);
                }
            }




            foreach (var loan in loans)
            {
                if (loanNameMap.Contains(loan.name))
                {
                    bool foundInhash = true;
                    if (foundInhash)
                    {
                        break;
                    }
                    else
                    {
                        result.Add(loan);
                    }

                }
                else
                {

                    result.Add(loan);
                }

            }


            return result;
        }
    }
}

