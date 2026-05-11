using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserRegisterDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserRegisterDiscountInfo : AopObject
    {
        /// <summary>
        /// 用户报名天天减活动时间
        /// </summary>
        [XmlElement("register_time")]
        public string RegisterTime { get; set; }

        /// <summary>
        /// 剩余可核销的优惠笔数
        /// </summary>
        [XmlElement("user_remaining_discount_count")]
        public long UserRemainingDiscountCount { get; set; }

        /// <summary>
        /// 报名后可享受的优惠笔数
        /// </summary>
        [XmlElement("user_total_discount_count")]
        public long UserTotalDiscountCount { get; set; }

        /// <summary>
        /// 累计核销优惠金额,单位:人民币 分
        /// </summary>
        [XmlElement("user_total_use_discount_amount")]
        public long UserTotalUseDiscountAmount { get; set; }
    }
}
