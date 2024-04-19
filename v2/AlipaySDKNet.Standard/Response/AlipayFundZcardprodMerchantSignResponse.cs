using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundZcardprodMerchantSignResponse.
    /// </summary>
    public class AlipayFundZcardprodMerchantSignResponse : AopResponse
    {
        /// <summary>
        /// 账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }
    }
}
