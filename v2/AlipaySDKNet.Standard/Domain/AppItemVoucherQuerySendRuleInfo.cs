using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherQuerySendRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherQuerySendRuleInfo : AopObject
    {
        /// <summary>
        /// 是否做身份证号限制
        /// </summary>
        [XmlElement("natural_person_limit")]
        public bool NaturalPersonLimit { get; set; }

        /// <summary>
        /// 是否做电话号码限制
        /// </summary>
        [XmlElement("phone_number_limit")]
        public bool PhoneNumberLimit { get; set; }

        /// <summary>
        /// 券发放的结束时间
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放的开始时间
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 发券总数，单位：个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 每人领取周期内限制次数
        /// </summary>
        [XmlElement("quantity_limit_per_user")]
        public long QuantityLimitPerUser { get; set; }

        /// <summary>
        /// 每人领取周期类型，单位：天，周，月，整个活动周期
        /// </summary>
        [XmlElement("quantity_limit_per_user_period_type")]
        public string QuantityLimitPerUserPeriodType { get; set; }

        /// <summary>
        /// 是否做实名限制
        /// </summary>
        [XmlElement("real_name_limit")]
        public bool RealNameLimit { get; set; }

        /// <summary>
        /// 是否启用用户ID的限制
        /// </summary>
        [XmlElement("user_id_limit")]
        public bool UserIdLimit { get; set; }

        /// <summary>
        /// 券发放场景
        /// </summary>
        [XmlElement("voucher_available_scene")]
        public string VoucherAvailableScene { get; set; }
    }
}
