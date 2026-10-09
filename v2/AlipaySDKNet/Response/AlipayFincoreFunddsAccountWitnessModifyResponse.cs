using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreFunddsAccountWitnessModifyResponse.
    /// </summary>
    public class AlipayFincoreFunddsAccountWitnessModifyResponse : AopResponse
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }
    }
}
