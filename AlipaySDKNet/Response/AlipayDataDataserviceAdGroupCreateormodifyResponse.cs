using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdGroupCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 外部单元编号
        /// </summary>
        [XmlElement("group_outer_id")]
        public string GroupOuterId { get; set; }
    }
}
