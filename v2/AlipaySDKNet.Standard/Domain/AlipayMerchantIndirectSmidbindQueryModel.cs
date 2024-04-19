using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectSmidbindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectSmidbindQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝商户id
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
