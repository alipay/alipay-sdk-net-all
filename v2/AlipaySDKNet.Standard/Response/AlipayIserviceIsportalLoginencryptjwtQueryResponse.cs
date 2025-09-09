using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsportalLoginencryptjwtQueryResponse.
    /// </summary>
    public class AlipayIserviceIsportalLoginencryptjwtQueryResponse : AopResponse
    {
        /// <summary>
        /// 加密的登录态jwt信息
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
