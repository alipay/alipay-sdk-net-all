using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountActivityBean Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountActivityBean : AopObject
    {
        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("activity_desc")]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// 活动详情ID
        /// </summary>
        [XmlElement("activity_detail_id")]
        public string ActivityDetailId { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 营销参数
        /// </summary>
        [XmlElement("marketing_param")]
        public MarketingParamBean MarketingParam { get; set; }

        /// <summary>
        /// 目标id
        /// </summary>
        [XmlElement("participate_id")]
        public string ParticipateId { get; set; }

        /// <summary>
        /// 目标类型
        /// </summary>
        [XmlElement("participate_type")]
        public string ParticipateType { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 状态     INIT((byte) 0, "初始化"),     EFFECTIVE((byte) 1, "有效的"),     EARLY_FINISHED((byte) 3, "被提前结束"),
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
