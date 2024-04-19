using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneMobileScreenApplyResponse.
    /// </summary>
    public class AlipayInsSceneMobileScreenApplyResponse : AopResponse
    {
        /// <summary>
        /// 投保外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单详情地址
        /// </summary>
        [XmlElement("policy_url")]
        public string PolicyUrl { get; set; }

        /// <summary>
        /// 保单保费（单位：分）
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }
    }
}
