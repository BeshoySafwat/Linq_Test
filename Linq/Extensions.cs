using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq;
    public static class Extensions
    {
        public static void PrintTable<T>(this IEnumerable<T> items)
        {
            if (!items.Any())
            {
                Console.WriteLine("No items to display.");
                return;
            }

            PropertyInfo[] properties = typeof(T).GetProperties();

            // Calculate column widths
            int[] columnWidths = new int[properties.Length];
            for (int i = 0; i < properties.Length; i++)
            {
                columnWidths[i] = Math.Max(
                    properties[i].Name.Length,
                    items.Max(item => properties[i].GetValue(item)?.ToString().Length ?? 0)
                );
            }

            // Print header
            string headerLine = string.Join(" | ", properties.Select((p, i) => p.Name.PadRight(columnWidths[i])));
            Console.WriteLine(new string('-', headerLine.Length));
            Console.WriteLine(headerLine);
            Console.WriteLine(new string('-', headerLine.Length));

            // Print rows
            foreach (var item in items)
            {
                string row = string.Join(" | ", properties.Select((p, i) =>
                    (p.GetValue(item)?.ToString() ?? "").PadRight(columnWidths[i])));
                Console.WriteLine(row);
            }
        }
    }
