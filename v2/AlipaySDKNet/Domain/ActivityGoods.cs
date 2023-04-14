using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityGoods Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityGoods : AopObject
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
        /// 活动权益信息
        /// </summary>
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 活动库存
        /// </summary>
        [XmlElement("stock")]
        public string Stock { get; set; }
    }
}
