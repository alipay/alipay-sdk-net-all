using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertdocCertverifyConsultResponse.
    /// </summary>
    public class AlipayUserCertdocCertverifyConsultResponse : AopResponse
    {
        /// <summary>
        /// 具体哪些字段不一致。与预授权的输入字段对应，类型为字符串列表的JSON格式。
        /// </summary>
        [XmlElement("fail_params")]
        public string FailParams { get; set; }

        /// <summary>
        /// 校验不一致时，描述不一致的原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 校验是否一致：T-一致、F-不一致
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
