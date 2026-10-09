using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceZhimaSubmerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceZhimaSubmerchantQueryModel : AopObject
    {
        /// <summary>
        /// 结算支付宝账号的登陆号
        /// </summary>
        [XmlElement("settle_alipay_login_id")]
        public string SettleAlipayLoginId { get; set; }
    }
}
