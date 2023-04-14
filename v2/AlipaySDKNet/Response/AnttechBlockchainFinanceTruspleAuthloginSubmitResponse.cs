using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleAuthloginSubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleAuthloginSubmitResponse : AopResponse
    {
        /// <summary>
        /// 四要素认证通过的authToken，可用于后续登录
        /// </summary>
        [XmlElement("auth_token")]
        public string AuthToken { get; set; }
    }
}
