using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneMarketingBlackcarduserGradeinfoQueryResponse.
    /// </summary>
    public class AntfortuneMarketingBlackcarduserGradeinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 检查结果是否通过：true/false
        /// </summary>
        [XmlElement("auth_result")]
        public string AuthResult { get; set; }
    }
}
