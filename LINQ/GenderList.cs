namespace LINQ
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>()
        {
            new Gender() { 
                Id = Guid.Parse("a7949a1c-16a3-4e0b-b31f-5322eed32c55"), 
                Sex = "male" 
            },
            new Gender() { 
                Id = Guid.Parse("f5956c17-2a59-496e-9663-1072e132d1e2"), 
                Sex = "female" 
            },
        };
    }
}
