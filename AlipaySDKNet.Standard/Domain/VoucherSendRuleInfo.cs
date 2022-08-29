using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSendRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSendRuleInfo : AopObject
    {
        /// <summary>
        /// 设置此字段，允许指定单天最大发券数量。
        /// </summary>
        [XmlElement("max_quantity_by_day")]
        public long MaxQuantityByDay { get; set; }

        /// <summary>
        /// 是否开启自然人领取限制。 自然人表示按照身份证纬度进行领取限制。
        /// </summary>
        [XmlElement("natural_person_limit")]
        public bool NaturalPersonLimit { get; set; }

        /// <summary>
        /// 是否开启电话号码领取限制。
        /// </summary>
        [XmlElement("phone_number_limit")]
        public bool PhoneNumberLimit { get; set; }

        /// <summary>
        /// 券发放结束时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 发行券的数量。
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 每人领取限制。 默认按照支付宝账号进行领取限制; 不填写或填入0表示没有领取限制.
        /// </summary>
        [XmlElement("quantity_limit_per_user")]
        public long QuantityLimitPerUser { get; set; }

        /// <summary>
        /// 周期限领配置,限制每人在固定周期内领取张数(voucher_quantity_limit_per_user),默认LIFE_CYCLE
        /// </summary>
        [XmlElement("quantity_limit_per_user_period_type")]
        public string QuantityLimitPerUserPeriodType { get; set; }

        /// <summary>
        /// 限制支付宝实名用户才能领取支付券,默认为false表示不限制 枚举值 true\false
        /// </summary>
        [XmlElement("real_name_limit")]
        public bool RealNameLimit { get; set; }
    }
}
