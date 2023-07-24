using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskMiniprogramVerifyidentityInitializeResponse.
    /// </summary>
    public class AlipaySecurityRiskMiniprogramVerifyidentityInitializeResponse : AopResponse
    {
        /// <summary>
        /// 返回给调用方的数据集合，具体数据由对接过程中双方共同确认
        /// </summary>
        [XmlElement("biz_data")]
        public InitBizData BizData { get; set; }

        /// <summary>
        /// 核身校验token，核身会话中唯一性token，用于后续核身结果二次校验时参数传入
        /// </summary>
        [XmlElement("verify_token")]
        public string VerifyToken { get; set; }

        /// <summary>
        /// 核身页面url
        /// </summary>
        [XmlElement("verify_url")]
        public string VerifyUrl { get; set; }
    }
}
