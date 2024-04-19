using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageItempackageConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourcepackageItempackageConsultModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("commodity_code")]
        public string CommodityCode { get; set; }

        /// <summary>
        /// 商品可购买周期数量
        /// </summary>
        [XmlElement("effective_period_num")]
        public long EffectivePeriodNum { get; set; }

        /// <summary>
        /// 商品可购买周期类型
        /// </summary>
        [XmlElement("effective_period_type")]
        public string EffectivePeriodType { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("purchase_number")]
        public long PurchaseNumber { get; set; }

        /// <summary>
        /// 商品规格编码
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
