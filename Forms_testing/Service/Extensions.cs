using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Forms_testing.Models;

namespace Forms_testing.Service
{
    static class Extensions
    {
        const char separator = ';';
        public static IEnumerable<Student> ReadStudents(StreamReader reader)
        {
            return GetStrings(reader)
                .Skip(1)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Split(separator))
                .Where(components => components.Length >= 8)
                .Select(components => new Student
                {
                    Id = int.Parse(components[0]),
                    LastName = components[1],
                    Name = components[2],
                    Patronymic = components[3],
                    Birthday = DateTime.Parse(components[4]),
                    Rating = double.Parse(components[5]),
                    GroupId = int.Parse(components[6])
                });
        }
        public static IEnumerable<string> GetStrings(StreamReader reader)
        {
            while (!reader.EndOfStream)
                yield return reader.ReadLine();
        }

        public static IEnumerable<Group> ReadGroups(StreamReader reader)
        {
            var groups = GetStrings(reader)
                .Skip(1)
                .Where(line => line.Length > 0)
                .Select(line => line.Split(separator))
                .Where(components => components.Length >= 4)
                .Select(components => new Group
                {
                    Id = int.Parse(components[0]),
                    Name = components[1],
                    Course = int.Parse(components[2]),
                    Description = components[3]
                });
            return groups;
        }
    }
}
