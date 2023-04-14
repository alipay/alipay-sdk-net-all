using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityGoodsStockIncrease Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityGoodsStockIncrease : AopObject
    {
        /// <summary>
        /// 单品唯一标识，标品使用69码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 活动权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 活动权益增补库存
        /// </summary>
        [XmlElement("increase_stock")]
        public string IncreaseStock { get; set; }
    }
}
