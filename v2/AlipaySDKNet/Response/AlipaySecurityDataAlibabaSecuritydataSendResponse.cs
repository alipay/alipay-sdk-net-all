using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataAlibabaSecuritydataSendResponse.
    /// </summary>
    public class AlipaySecurityDataAlibabaSecuritydataSendResponse : AopResponse
    {
        /// <summary>
        /// 返回数据写入后详细信息，一般为数据唯一key
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }
    }
}
