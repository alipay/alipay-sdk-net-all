using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenManjiangtesttttDepositbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenManjiangtesttttDepositbackModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }
    }
}
