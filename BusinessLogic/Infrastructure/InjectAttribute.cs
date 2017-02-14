using System;

namespace BusinessLogic.Infrastructure
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class InjectAttribute : Attribute
    {
    }
}
