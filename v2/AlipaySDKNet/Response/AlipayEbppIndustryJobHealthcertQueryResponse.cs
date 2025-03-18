using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobHealthcertQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryJobHealthcertQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有证，有证返回true，无证返回false
        /// </summary>
        [XmlElement("has_cert")]
        public bool HasCert { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 从业类别
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 健康证有效期，单位：天 枚举值: 距过期时间>30天， 距过期时间≤30天， 失效日期＞60天, 失效日期＞90天, 失效日期＞180天, 已过期
        /// </summary>
        [XmlElement("valid_period")]
        public string ValidPeriod { get; set; }
    }
}
