using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointVoucherprodBenefittemplateQueryModel : AopObject
    {
        /// <summary>
        /// 资产id，即权益模板id，创建权益模板时返回的id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型，由支付宝权益结算平台定义，BENEFIT_TEMPLATE表示权益模板
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 权益产品码，不同场景下会有不同的产品码，由支付宝权益结算平台指定，GAODE_GENERAL_SHADOW表示高德权益结算场景下的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 支付宝会员id，需要查询的权益模板所属商家的支付宝会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
