using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonVoucherSendRule Data Structure.
    /// </summary>
    [Serializable]
    public class CommonVoucherSendRule : AopObject
    {
        /// <summary>
        /// 设置此字段，允许指定单天最大发券数量。
        /// </summary>
        [XmlElement("max_quantity_by_day")]
        public long MaxQuantityByDay { get; set; }

        /// <summary>
        /// 限制相同身份证号领取次数(voucher_quantity_limit_per_user)。默认false不限制。 枚举值 true：是 false：否
        /// </summary>
        [XmlElement("natural_person_limit")]
        public bool NaturalPersonLimit { get; set; }

        /// <summary>
        /// 限制相同手机号领取次数(voucher_quantity_limit_per_user)。默认false不限制 枚举值 true：是 false：否
        /// </summary>
        [XmlElement("phone_number_limit")]
        public bool PhoneNumberLimit { get; set; }

        /// <summary>
        /// 限制支付宝实名用户才能领取支付券，默认为false表示不限制。枚举值 true\false
        /// </summary>
        [XmlElement("real_name_limit")]
        public bool RealNameLimit { get; set; }

        /// <summary>
        /// 发行券的总数量。
        /// </summary>
        [XmlElement("voucher_quantity")]
        public long VoucherQuantity { get; set; }

        /// <summary>
        /// 每人领取限制。 默认按照支付宝账号进行领取限制; 不填写或填入0表示没有领取限制。
        /// </summary>
        [XmlElement("voucher_quantity_limit_per_user")]
        public long VoucherQuantityLimitPerUser { get; set; }

        /// <summary>
        /// 周期限领配置,限制每人在固定周期内领取张数（voucher_quantity_limit_per_user），默认LIFE_CYCLE。
        /// </summary>
        [XmlElement("voucher_quantity_limit_per_user_period_type")]
        public string VoucherQuantityLimitPerUserPeriodType { get; set; }
    }
}
