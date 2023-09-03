namespace MyDAO
{
    internal class Dyspeciality : DySpeciality
    {
        private string v1;
        private int v2;

        public Dyspeciality(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override string ToString()
        {
            return v2 + "  " + v1;
        }
    }
}