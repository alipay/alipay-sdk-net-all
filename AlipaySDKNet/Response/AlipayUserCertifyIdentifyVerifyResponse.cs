using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyIdentifyVerifyResponse.
    /// </summary>
    public class AlipayUserCertifyIdentifyVerifyResponse : AopResponse
    {
        /// <summary>
        /// 校验结果，T表示满足条件，F表示不满足条件
        /// </summary>
        [XmlElement("biz_code_status")]
        public string BizCodeStatus { get; set; }
    }
}
