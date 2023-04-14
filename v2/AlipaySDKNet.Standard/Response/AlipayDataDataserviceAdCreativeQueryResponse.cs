using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeQueryResponse : AopResponse
    {
        /// <summary>
        /// 创意详情
        /// </summary>
        [XmlElement("creative_detail")]
        public CreativeDetail CreativeDetail { get; set; }
    }
}
