using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryMerchantRule Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryMerchantRule : AopObject
    {
        /// <summary>
        /// 指定品牌id。 说明：如商户需选择某个品牌下维护的收款账号，请上传相关品牌id
        /// </summary>
        [XmlArray("brand_id_list")]
        [XmlArrayItem("string")]
        public List<string> BrandIdList { get; set; }

        /// <summary>
        /// 曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号
        /// </summary>
        [XmlArray("delivery_merchant_infos")]
        [XmlArrayItem("delivery_merchant_info")]
        public List<DeliveryMerchantInfo> DeliveryMerchantInfos { get; set; }

        /// <summary>
        /// 指定支付成功页模式。 枚举值： MANUAL_INPUT_MERCHANT：指定收款账号 IN_SERVICE_VOUCHER_MERCHANT：优惠券可核收款账号（仅支持支付券） 收款账号相关规则:接入指南
        /// </summary>
        [XmlElement("delivery_merchant_mode")]
        public string DeliveryMerchantMode { get; set; }
    }
}
