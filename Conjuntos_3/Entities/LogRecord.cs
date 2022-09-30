
namespace Conjuntos_3.Entities
{
    public class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }
        public LogRecord(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }
        public override int GetHashCode(){
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
         
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            LogRecord other = obj as LogRecord;
            return UserName.Equals(other.UserName);
        }
   
    }
}