using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserIncomeQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class UserIncomeQueryResponse : AopObject
    {
        /// <summary>
        /// 收入金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收入月份
        /// </summary>
        [XmlElement("biz_month")]
        public string BizMonth { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 官网用户id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 海图用户id
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }
    }
}
