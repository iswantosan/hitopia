using System.Collections.Generic;

namespace HitopiaTest
{
    public static class WeightedString
    {
        private static Dictionary<string, int> CalculateWeights(string input)
        {
            var weights = new Dictionary<string, int>();
            int weight = 0;
            string ch = null;

            foreach (char c in input)
            {
                if (c.ToString() != ch)
                {
                    ch = c.ToString();
                    weight = c - 'a' + 1;
                    weights[c.ToString()] = weight;
                }
                else
                {
                    weight += c - 'a' + 1;
                    weights[ch + c.ToString()] = weight;
                }
            }
            if (ch != null)
            {
                weights[ch] = weight;
            }
            return weights;
        }

        public static List<string> CheckQueries(string input, int[] queries)
        {
            Dictionary<string, int> weights = CalculateWeights(input);
            List<string> outputs = new List<string>();

            foreach (int query in queries)
            {
                bool found = false;
                foreach (KeyValuePair<string, int> kv in weights)
                {
                    if (query == kv.Value)
                    {
                        outputs.Add(Const.YES);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    outputs.Add(Const.NO);
                }
            }
            return outputs;
        }

    }
}
