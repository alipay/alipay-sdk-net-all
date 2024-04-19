using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceAccessQueryResponse.
    /// </summary>
    public class ZhimaCreditEpAcceptanceAccessQueryResponse : AopResponse
    {
        /// <summary>
        /// 芝麻企业信用数据访问令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 用户接入企业信用受理台服务H5页面地址
        /// </summary>
        [XmlElement("access_url")]
        public string AccessUrl { get; set; }
    }
}
