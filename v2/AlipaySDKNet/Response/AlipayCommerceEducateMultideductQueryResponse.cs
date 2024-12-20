using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateMultideductQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateMultideductQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝协议支付的协议号。OPEN时返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 校园支付开通状态。可选的字段枚举说明：{WAIT_SIGN_AGREEMENT:待签约协议支付;OPEN:校园支付开通;CLOSE:校园支付关闭}
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 资产信息，入参token上送的时候才会返回
        /// </summary>
        [XmlElement("asset")]
        public string Asset { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 学校或教育机构内标
        /// </summary>
        [XmlElement("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 学生或教职工在学校（或教育机构）的唯一编号。使用校园支付token查询时，返回当前字段
        /// </summary>
        [XmlElement("user_unique_id")]
        public string UserUniqueId { get; set; }
    }
}
