using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsportalEncryptQueryResponse.
    /// </summary>
    public class AlipayIserviceIsportalEncryptQueryResponse : AopResponse
    {
        /// <summary>
        /// 公钥
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
