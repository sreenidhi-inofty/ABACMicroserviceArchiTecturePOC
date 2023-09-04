using System.Collections.Generic;

namespace AuthorizationService
{
    public class PolicyViewModel
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public List<string> Parameters { get; set; }
    }
}
