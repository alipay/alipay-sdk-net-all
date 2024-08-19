using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherSendRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherSendRuleInfo : AopObject
    {
        /// <summary>
        /// 【描述】是否开启自然人领取限制， 自然人表示按照身份证纬度进行领取限制。 【枚举值】 ● true：是 ● false：否
        /// </summary>
        [XmlElement("natural_person_limit")]
        public bool NaturalPersonLimit { get; set; }

        /// <summary>
        /// 是否开启电话号码领取限制 【枚举值】 ● true：是 ● false：否
        /// </summary>
        [XmlElement("phone_number_limit")]
        public bool PhoneNumberLimit { get; set; }

        /// <summary>
        /// 券发放结束时间， 格式：yyyy-MM-dd HH:mm:ss 匹配格式yyyy-MM-dd HH:mm:ss的date类型
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放结束时间， 格式：yyyy-MM-dd HH:mm:ss 匹配格式yyyy-MM-dd HH:mm:ss的date类型
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 【描述】发行券的总数量；取值范围： [1,99999999] 单位：张
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 每人领取限制，配合quantity_limit_per_user_period_type使用 单位：次
        /// </summary>
        [XmlElement("quantity_limit_per_user")]
        public long QuantityLimitPerUser { get; set; }

        /// <summary>
        /// 周期限领配置，限制每人在固定周期内领取 【枚举值】 每周: DAY 每周: WEEK 每月: MONTH 整个活动周期: LIFE_CYCLE
        /// </summary>
        [XmlElement("quantity_limit_per_user_period_type")]
        public string QuantityLimitPerUserPeriodType { get; set; }

        /// <summary>
        /// 【描述】限制支付宝实名用户才能领取支付券 【枚举值】 ● true：是 ● false：否
        /// </summary>
        [XmlElement("real_name_limit")]
        public bool RealNameLimit { get; set; }

        /// <summary>
        /// 【描述】是否开启支付宝账号领取限制，  【枚举值】 ● true：是 ● false：否
        /// </summary>
        [XmlElement("user_id_limit")]
        public bool UserIdLimit { get; set; }

        /// <summary>
        /// 限制该券在指定哪些场景下可以正常展示，以及用户可正常领取。 【枚举值】 ● 货架场景：SHELF_SCENE ● 直播互动区：LIVE
        /// </summary>
        [XmlElement("voucher_available_scene")]
        public string VoucherAvailableScene { get; set; }
    }
}
