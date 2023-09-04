using Microsoft.AspNetCore.Mvc;

namespace ProductMicroservice.Utils
{
    public class MultiplePolicysAuthorizeAttribute : TypeFilterAttribute
    {
        public MultiplePolicysAuthorizeAttribute(string policys, bool isAnd = false) : base(typeof(MultiplePolicysAuthorizeFilter))
        {
            Arguments = new object[] { policys, isAnd };
        }
    }
}
