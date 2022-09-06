namespace Batch1_DET_2022
{
    internal class OnetoManyDataContext
    {
        public OnetoManyDataContext()
        {
        }

        public object Orders { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}