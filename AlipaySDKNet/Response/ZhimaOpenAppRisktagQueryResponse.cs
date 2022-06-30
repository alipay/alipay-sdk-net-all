using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaOpenAppRisktagQueryResponse.
    /// </summary>
    public class ZhimaOpenAppRisktagQueryResponse : AopResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [XmlElement("resp")]
        public string Resp { get; set; }
    }
}
