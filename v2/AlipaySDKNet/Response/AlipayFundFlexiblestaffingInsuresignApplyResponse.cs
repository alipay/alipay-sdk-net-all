using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingInsuresignApplyResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingInsuresignApplyResponse : AopResponse
    {
        /// <summary>
        /// 签约企业支付宝账号id
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 企业支付宝账号Id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 签约链接
        /// </summary>
        [XmlElement("apply_link")]
        public string ApplyLink { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
