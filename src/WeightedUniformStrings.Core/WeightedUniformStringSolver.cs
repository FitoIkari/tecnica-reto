using WeightedUniformStrings.Core.Extensions;

namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        if (string.IsNullOrEmpty(s)) return queries.Select(x => $"No").ToList();
        
        Dictionary<string, int> U = new();

        char lastChar = s[0];
        string aux = s[0].ToString();


        for (int i = 1; i < s.Length; i++)
        {
            char c = s[i];
            if (c == lastChar)
            { 
                aux += c;
                continue;
            }

            if(U.ContainsKey(aux))
                U[aux] += aux.CalcWeigth();
            else
                U.Add(aux, aux.CalcWeigth());
            aux = c.ToString();
            lastChar = c;
        }



        return queries
            .Select(x => U.Any(u => u.Value == x) ? "Yes" : "No")
            .ToList();
    }
}
