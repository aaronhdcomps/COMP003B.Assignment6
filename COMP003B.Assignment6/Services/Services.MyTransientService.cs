namespace COMP003B.Assignment6.Services
{
    public class MyTransientService
    {
        //Private GUID  field
        private readonly Guid _uniqueId;

        //Default Constructor
        public MyTransientService() 
        {
            _uniqueId= Guid.NewGuid();
        }

        //Public Method that returns uniqueId value
        public Guid GetUniqueId() 
        {
            return _uniqueId;
        }
    }
}
