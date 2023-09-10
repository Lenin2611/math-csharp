using System.Diagnostics.Contracts;
using System.Xml.Linq;

namespace escuelaCampus.Entities;
public class Student
{
    private string id;
    private string name;
    private string email;
    private int age;
    private string address;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    private List<int> quiz = new List<int> {0,0,0,0};
    private List<int> work = new List<int> {0,0};
    private List<int> assessment = new List<int> {0,0,0};

    public List<int> Quiz
    {
        get { return quiz; }
        set { quiz = value; }
    }
    public List<int> Work
    {
        get { return work; }
        set { work = value; }
    }
    public List<int> Assessment
    {
        get { return assessment; }
        set { assessment = value; }
    }

    private double finalQuiz;
    private double finalWork;
    private double finalAssessment;
    private double final;

    public double FinalQuiz
    {
        get { return finalQuiz; }
        set { finalQuiz = value; }
    }
    public double FinalWork
    {
        get { return finalWork; }
        set { finalWork = value; }
    }
    public double FinalAssessment
    {
        get { return finalAssessment; }
        set { finalAssessment = value; }
    }
    public double Final
    {
        get { return final; }
        set { final = value; }
    }

    public Student()
    {
    }
    public Student(string id, string name, string email, int age, string address, List<int> quiz, List<int> work, List<int> assessment, double finalQuiz, double finalWork, double finalAssessment, double final)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.age = age;
        this.address = address;
        this.quiz = quiz;
        this.work = work;
        this.assessment = assessment;
        this.finalQuiz = finalQuiz;
        this.finalWork = finalWork;
        this.finalAssessment = finalAssessment;
        this.final = final;
    }
}