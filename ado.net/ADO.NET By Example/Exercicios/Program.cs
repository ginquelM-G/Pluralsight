using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(); s.Age=20; s.Name = "Anacleto";
            
            Validator<Student> validator = ValidatorBuilder
             .Build<Student>()
             .AddValidation("Age", new Above18())
             .AddValidation("Name", new NotNull());

           ///validator.Validate(s);
                                    .
                                            
                                            
        }
    }


    struct Student
    {
        public int Age;
        public String Name;
    }

    public class Validator<T>
    {
        Dictionary<String, Ivalidation> v = new Dictionary<string, Ivalidation>();
        public Validator<T> AddValidation(String s, Ivalidation iValidation)
        {
            //return Ivalidation;
            //throw new ValidationException()
            v.Add(s, iValidation);
            return this;
        }


        void Validate(T t)
        {
            
        }


    }

    class ValidationException: Exception
    {

    }

    public interface Ivalidation
    {
        bool Validate(object obj);
    }

    class Above18 : Ivalidation
    {
        public bool Validate(object val)
        {
           return (int)val > 18;
        }
    }

    class NotNull : Ivalidation
    {
        public bool Validate(object obj)
        {
            return obj == null ? true : false;
        }
    }

    class ValidatorBuilder{
        static public Validator<T> Build<T>(){
            return new Validator<T>();
        }
    }
}
