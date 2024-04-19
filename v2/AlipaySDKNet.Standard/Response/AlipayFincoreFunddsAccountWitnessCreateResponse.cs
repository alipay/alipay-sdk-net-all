using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreFunddsAccountWitnessCreateResponse.
    /// </summary>
    public class AlipayFincoreFunddsAccountWitnessCreateResponse : AopResponse
    {
        /// <summary>
        /// 开户账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }
    }
}
