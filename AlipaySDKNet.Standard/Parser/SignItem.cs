namespace Aop.Api.Parser

{
    public class SignItem
    {
        public string SignSourceData { get; set; }
        public string Sign { get; set; }

        public override string ToString()
        {
            return "{" +
                "Sign:" + Sign +
                ",SignSourceData:" + SignSourceData +
                "}";
        }
    }
}
