using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundQuotaQueryResponse.
    /// </summary>
    public class AlipayFundQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 对公日可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_corporate_daily_available_amount")]
        public string ToCorporateDailyAvailableAmount { get; set; }

        /// <summary>
        /// 对公月可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_corporate_monthly_available_amount")]
        public string ToCorporateMonthlyAvailableAmount { get; set; }

        /// <summary>
        /// 对私日可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_private_daily_available_amount")]
        public string ToPrivateDailyAvailableAmount { get; set; }

        /// <summary>
        /// 对私月可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_private_monthly_available_amount")]
        public string ToPrivateMonthlyAvailableAmount { get; set; }
    }
}
