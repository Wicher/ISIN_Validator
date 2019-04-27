namespace ISIN_Validator.Models
{
    public class IsinCountry
    {
        public string Code { get; }
        public string Name { get; }

        public IsinCountry(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Code} - {Name}";
        }
    }
}
