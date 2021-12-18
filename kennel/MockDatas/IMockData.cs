using kennel.Data;

namespace kennel.MockDatas
{
   public interface IMockData
    {
        public IDatabaseUsingLists Db { get; set; }

        void GenerateCustomer();
    }
}