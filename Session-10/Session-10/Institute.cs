using System;

namespace Session_10
{

    public class Institute
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }
        public Institute()
        {
            ID= Guid.NewGuid();
        }       
    }
}
