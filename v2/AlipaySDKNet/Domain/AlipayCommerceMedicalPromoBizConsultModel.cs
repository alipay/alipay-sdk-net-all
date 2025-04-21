using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPromoBizConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPromoBizConsultModel : AopObject
    {
        /// <summary>
        /// LM配置商品价格时填的客户业务值（权益id），医疗用来区分代币种类
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 阿里云侧的客户业务 ID，运营新增活动时会新增
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 医疗商品id
        /// </summary>
        [XmlElement("med_benefit_id")]
        public string MedBenefitId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 阿里云侧的skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
