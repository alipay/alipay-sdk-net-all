using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 单元详情
        /// </summary>
        [XmlElement("group_detail")]
        public OuterGroup GroupDetail { get; set; }
    }
}
