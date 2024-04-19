using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletPayurlApplyResponse.
    /// </summary>
    public class AlipayFundWalletPayurlApplyResponse : AopResponse
    {
        /// <summary>
        /// 跳转前端申请付款码的短链接
        /// </summary>
        [XmlElement("payment_url")]
        public string PaymentUrl { get; set; }
    }
}
