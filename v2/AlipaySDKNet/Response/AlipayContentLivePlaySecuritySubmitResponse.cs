using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLivePlaySecuritySubmitResponse.
    /// </summary>
    public class AlipayContentLivePlaySecuritySubmitResponse : AopResponse
    {
        /// <summary>
        /// 外部业务id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
