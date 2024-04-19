using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtRcvQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtRcvQueryModel : AopObject
    {
        /// <summary>
        /// rcv编号
        /// </summary>
        [XmlElement("rcv_number")]
        public string RcvNumber { get; set; }
    }
}
