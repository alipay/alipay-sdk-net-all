using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpBenefitDataVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpBenefitDataVO : AopObject
    {
        /// <summary>
        /// 权益logo
        /// </summary>
        [XmlElement("benefit_logo")]
        public string BenefitLogo { get; set; }

        /// <summary>
        /// 权益主标题
        /// </summary>
        [XmlElement("benefit_main_title")]
        public string BenefitMainTitle { get; set; }

        /// <summary>
        /// 权益商家名称
        /// </summary>
        [XmlElement("benefit_merchant_name")]
        public string BenefitMerchantName { get; set; }

        /// <summary>
        /// 权益副标题
        /// </summary>
        [XmlElement("benefit_sub_title")]
        public string BenefitSubTitle { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 距离描述
        /// </summary>
        [XmlElement("distance_desc")]
        public string DistanceDesc { get; set; }

        /// <summary>
        /// 门槛金额
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 奖品面额，精确到小数点两位。对于代金券来说是金额，对于折扣券来说是折
        /// </summary>
        [XmlElement("prize")]
        public string Prize { get; set; }

        /// <summary>
        /// 元/折
        /// </summary>
        [XmlElement("prize_unit")]
        public string PrizeUnit { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
