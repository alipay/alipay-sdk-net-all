using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HelloHq Data Structure.
    /// </summary>
    [Serializable]
    public class HelloHq : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
