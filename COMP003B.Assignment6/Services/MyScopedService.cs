namespace COMP003B.Assignment6.Services
{
    public class MyScopedService
    {
        //Private field
        private readonly Guid _uniqueId;

        //default constructor
        public MyScopedService() 
        { 
            _uniqueId= Guid.NewGuid();
        }

        //public method that returns uniqueId value
        public Guid GetUniqueId() 
        {
            return _uniqueId;
        } 
    }
}
