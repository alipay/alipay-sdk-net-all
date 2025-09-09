using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityVoiceprintPrecreateResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityVoiceprintPrecreateResponse : AopResponse
    {
        /// <summary>
        /// 预注册结果
        /// </summary>
        [XmlElement("pre_register_result")]
        public string PreRegisterResult { get; set; }

        /// <summary>
        /// 注册成功的数据，一个token
        /// </summary>
        [XmlElement("register_data")]
        public string RegisterData { get; set; }
    }
}
