using System;

namespace Session-06
{

    public class Institute
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }
        public Institute()
        {

        }
        public Institute(Guid id)
        {
            Id = id;
        }
        public Institute(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public Institute(Guid id, string name, int yearsInService)
        {
            Id = id;
            Name = name;
            YearsInService = yearsInService;
        }   
        public void GetName()
        {

        }
        public void SetName(string name)
        {

        }
    }
}
