using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
class ADTask
{
    public static IEnumerable<Student> Filter(IEnumerable<Student> students)
    {
        IEnumerable<Student> students75 = from student in students
                                          where student.Rating>75
                                          select student;
        List<Student> sorts = new List<Student>();
        foreach (var st in students75)
        {
            foreach(string sub in st.Subjects)
            {
                if (sub =="Math"|| sub == "English")
                {
                    st.Group = st.Group.ToUpper();
                    sorts.Add(st);
                    break;
                }
            }
        }
        return sorts;
    }
    public static string SearchLongestWordStartingWithAa(string sentence)
    {
        List<string> words = new List<string>();
        using (StreamReader sr = new StreamReader(sentence))
        {
            string line;
            
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {
                    if (part[0] == 'a')
                    {
                        words.Add(part);
                    }
                }
            }
            
        }
        string longest;
        if (words.Count > 0)
        {
            longest = words[0];
            for (int i = 1; i < words.Count; i++)
            {
                if (words[i].Length > longest.Length)
                {
                    longest = words[i];
                }
            }
            return longest;
        }
        else
        {
            return " ";
        }

    }
}
class Student
{
    public int Rating { get; set; }
    public string Name { get; set; }
    public string Group { get; set; }
    public List<string> Subjects { get; } = new List<string>();
    public override bool Equals( object obj)
    {
        if(obj is Student otherStudent)
        {
            return Name == otherStudent.Name && Rating == otherStudent.Rating && Group == otherStudent.Group;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode()^Rating;
    }

}