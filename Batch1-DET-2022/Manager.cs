namespace Batch1_DET_2022
{
    internal class Manager : empdetails
    {
        private int v1;
        private string v2;
        private DateOnly dateOnly;
        private string v3;
        private int v4;

        public Manager(int v1, string v2, DateOnly dateOnly, string v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dateOnly = dateOnly;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}