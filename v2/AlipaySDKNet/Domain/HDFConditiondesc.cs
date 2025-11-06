using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFConditiondesc Data Structure.
    /// </summary>
    [Serializable]
    public class HDFConditiondesc : AopObject
    {
        /// <summary>
        /// 病情描述
        /// </summary>
        [XmlElement("condition_desc")]
        public string ConditionDesc { get; set; }
    }
}
