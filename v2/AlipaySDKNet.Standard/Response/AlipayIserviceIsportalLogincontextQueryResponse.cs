using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsportalLogincontextQueryResponse.
    /// </summary>
    public class AlipayIserviceIsportalLogincontextQueryResponse : AopResponse
    {
        /// <summary>
        /// 登录信息
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
