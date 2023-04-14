using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenProductOpenstateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenProductOpenstateQueryModel : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// sv要查询商户签约状态的产品码，产品码是支付宝内部对产品的唯一标识。目前支持查询产品及产品码详情参见 https://opendocs.alipay.com/isv/01cv77#%E8%83%BD%E5%8A%9B%E4%BA%A7%E5%93%81%E7%A0%81 。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
