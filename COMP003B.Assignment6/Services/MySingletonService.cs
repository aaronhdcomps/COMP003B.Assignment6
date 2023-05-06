namespace COMP003B.Assignment6.Services
{
    public class MySingletonService
    {
        //Private field
        private readonly Guid _uniqueId;

        //default constructor
        public MySingletonService()
        { 
            _uniqueId= Guid.NewGuid();
        }

        //Method returns uniqueId value
        public Guid GetUniqueId()
        { 
            return _uniqueId; 
        }
    }
}
