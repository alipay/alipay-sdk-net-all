using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAltechlegalDepositCreateResponse.
    /// </summary>
    public class AlipaySecurityProdAltechlegalDepositCreateResponse : AopResponse
    {
        /// <summary>
        /// 存证发起成功时返回
        /// </summary>
        [XmlElement("deposit_no")]
        public string DepositNo { get; set; }
    }
}
