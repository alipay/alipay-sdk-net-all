using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletDepositruleApplyResponse.
    /// </summary>
    public class AlipayFundWalletDepositruleApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请凭证
        /// </summary>
        [XmlElement("apply_token")]
        public string ApplyToken { get; set; }

        /// <summary>
        /// 申请链接
        /// </summary>
        [XmlElement("apply_url")]
        public string ApplyUrl { get; set; }
    }
}
