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
        public static IEnumerable<Student> ReadStudents(StreamReader reader)
        {
            if (!reader.EndOfStream)
            reader.ReadLine();

            const char separator = ';';
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                var components = line.Split(separator);

                var id = int.Parse(components[0]);
                var birthday = DateTime.Parse(components[4]);
                var rating = double.Parse(components[5]);
                var group_id = int.Parse(components[6]);
                var student = new Student
                {
                    Id = id,
                    LastName = components[1],
                    Name = components[2],
                    Patronymic = components[3],
                    Birthday = birthday,
                    Rating = rating,
                    GroupId = group_id
                };
                yield return student;
            }
        }
    }
}
