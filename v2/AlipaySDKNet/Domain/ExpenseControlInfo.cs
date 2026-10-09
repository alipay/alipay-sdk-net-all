using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseControlInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseControlInfo : AopObject
    {
        /// <summary>
        /// 费控规则id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
