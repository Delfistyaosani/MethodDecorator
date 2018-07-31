using MethodDecorator.Fody.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDecorator.Fody.Interfaces
{
    [AttributeUsage(AttributeTargets.Method)]
    public class SupportsApprovalAttribute : Attribute, IAspectMatchingRule
    {
        public virtual string AttributeTargetTypes { get; set; }
        public virtual bool AttributeExclude { get; set; }
        public virtual int AttributePriority { get; set; }
        public SupportsApprovalAttribute()
        {
        }
    }
}
