using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneMarketingBlackcarduserUserinfoQueryResponse.
    /// </summary>
    public class AntfortuneMarketingBlackcarduserUserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 检查结果是否通过：true/false
        /// </summary>
        [XmlElement("auth_result")]
        public string AuthResult { get; set; }
    }
}
