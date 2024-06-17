using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillTermAmountVO Data Structure.
    /// </summary>
    [Serializable]
    public class BillTermAmountVO : AopObject
    {
        /// <summary>
        /// 利息，元
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 本金，元
        /// </summary>
        [XmlElement("prin")]
        public string Prin { get; set; }
    }
}
