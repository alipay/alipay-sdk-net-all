using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RetailPointPrizeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RetailPointPrizeInfoDTO : AopObject
    {
        /// <summary>
        /// 积分奖品的面额，如奖品为30元优惠券，则该字段值为30，默认单位为元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 奖品面额单位，金额类奖品返回元，折扣类奖品返回折，具体可见枚举值。
        /// </summary>
        [XmlElement("discount_amount_unit")]
        public string DiscountAmountUnit { get; set; }

        /// <summary>
        /// 对应奖品的使用门槛金额，如满50减20元优惠券奖品，则该字段对应为50，默认单位为元。
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 活动任务参与单位 当前字段已废弃(不再使用该字段，后续废弃不会返回。)
        /// </summary>
        [XmlElement("join_limit")]
        public string JoinLimit { get; set; }

        /// <summary>
        /// 兑换奖品后续使用是否支持nfc支付
        /// </summary>
        [XmlElement("nfc_pay")]
        public bool NfcPay { get; set; }

        /// <summary>
        /// 兑换该奖品需要消耗的积分数量
        /// </summary>
        [XmlElement("point_count")]
        public long PointCount { get; set; }

        /// <summary>
        /// 对应奖品的id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品的名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 积分奖品的类型，具体看枚举值描述
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 活动任务剩余需参与的数量，结合状态可判断还剩多少数量即可完成活动任务进行兑换 当前字段已废弃(不再使用该字段，后续废弃不会返回。)
        /// </summary>
        [XmlElement("remaining_join_count")]
        public long RemainingJoinCount { get; set; }

        /// <summary>
        /// 对应活动的id
        /// </summary>
        [XmlElement("retail_activity_id")]
        public string RetailActivityId { get; set; }

        /// <summary>
        /// 奖品兑换的状态，用于判断如何展示 当前字段已废弃(仅返回有效的奖品，不再使用该字段，后续废弃不会返回。)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
