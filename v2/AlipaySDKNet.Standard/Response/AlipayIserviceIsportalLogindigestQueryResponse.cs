using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsportalLogindigestQueryResponse.
    /// </summary>
    public class AlipayIserviceIsportalLogindigestQueryResponse : AopResponse
    {
        /// <summary>
        /// 登录摘要
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
