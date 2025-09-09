using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappLayerCreateResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappLayerCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建活动成功时返回的活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
