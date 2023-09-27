using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskMiniprogramVerifyidentityConfirmResponse.
    /// </summary>
    public class AlipaySecurityRiskMiniprogramVerifyidentityConfirmResponse : AopResponse
    {
        /// <summary>
        /// 返回给调用方的数据集合，具体数据由对接过程中双方共同确认
        /// </summary>
        [XmlElement("biz_data")]
        public CheckBizData BizData { get; set; }

        /// <summary>
        /// 身份校验结果
        /// </summary>
        [XmlElement("verify_result")]
        public bool VerifyResult { get; set; }
    }
}
