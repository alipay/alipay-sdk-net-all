using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityGoodsBenefit Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityGoodsBenefit : AopObject
    {
        /// <summary>
        /// 活动权益配置的券活动id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 活动变更后的初始化库存
        /// </summary>
        [XmlElement("stock")]
        public string Stock { get; set; }
    }
}
