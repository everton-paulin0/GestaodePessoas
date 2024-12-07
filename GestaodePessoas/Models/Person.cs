using GestaodePessoas.Enum;

namespace GestaodePessoas.Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
            
        }

        public Person(string fullName, double docNumber, DocType typeDocument, Especiality especality)
        {
            FullName = fullName;
            DocNumber = docNumber;
            TypeDocument = typeDocument;
            Especality = especality;
        }

        public string FullName { get; set; }
        public double DocNumber { get; set; }
        public DocType TypeDocument { get; set; }
        public Especiality Especality { get; set; }
        


    }
}
