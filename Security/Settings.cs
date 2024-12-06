namespace blogpessoal.Security
{
    public class Settings
    {
        private static string secret = "750f1d1e1a676904ce84834752771502e2d304bc5a805c7d5bae30f0a59b1e71";

        public static string Secret { get => secret; set => secret = value; }

    }
}