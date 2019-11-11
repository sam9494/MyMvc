using MyMvc.Models;

namespace MyMvc.model
{
    public class SetViewModel
    {
        
        public HelloViewModel Get()
        {
            return new HelloViewModel
            {
                Name = "sam" ,
                Age = 24
            };

        }
    }
}