using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSubMerchantVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentSubMerchantVO : AopObject
    {
        /// <summary>
        /// 支付宝二级商户编号。 间连受理商户的支付宝商户编号，通过间连商户入驻接口后由支付宝生成。 直付通和机构间连业务场景下有值
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 二级商户编号类型
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }
    }
}
