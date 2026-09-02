using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserAvailableVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class UserAvailableVoucher : AopObject
    {
        /// <summary>
        /// 航司二字码，比如:MU|CA
        /// </summary>
        [XmlElement("ac_code")]
        public string AcCode { get; set; }

        /// <summary>
        /// 券生效时间
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 到达机场三字码，该券的限制使用条件之一，正则匹配
        /// </summary>
        [XmlElement("arr_airport_code")]
        public string ArrAirportCode { get; set; }

        /// <summary>
        /// 出发机场三字码，该券的限制使用条件之一，正则匹配
        /// </summary>
        [XmlElement("dep_airport_code")]
        public string DepAirportCode { get; set; }

        /// <summary>
        /// 券可使用的航班起飞日期
        /// </summary>
        [XmlElement("dep_date")]
        public string DepDate { get; set; }

        /// <summary>
        /// 券失效时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 券可使用的航班号,券可使用的限制条件之一，正则匹配
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 可使用的商户code，HUOLI、TONGCHNEG、VARI、FLIGGY、CH、TUNIU等等，该券的限制使用条件之一
        /// </summary>
        [XmlElement("ota_code")]
        public string OtaCode { get; set; }

        /// <summary>
        /// 券可使用的商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 核销规则
        /// </summary>
        [XmlElement("promo_rules")]
        public string PromoRules { get; set; }

        /// <summary>
        /// 支付宝机票券模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 优惠券金额
        /// </summary>
        [XmlElement("voucher_amount")]
        public string VoucherAmount { get; set; }

        /// <summary>
        /// 券描述
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 支付宝机票券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 支付宝机票券类型，比如COMMON通用券, DYNAMIC动态券
        /// </summary>
        [XmlElement("voucher_source_type")]
        public string VoucherSourceType { get; set; }
    }
}
