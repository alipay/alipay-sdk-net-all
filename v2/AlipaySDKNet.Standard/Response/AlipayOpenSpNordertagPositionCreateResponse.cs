using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordertagPositionCreateResponse.
    /// </summary>
    public class AlipayOpenSpNordertagPositionCreateResponse : AopResponse
    {
        /// <summary>
        /// 点位id,主要为新建点位时生成的点位唯一标识
        /// </summary>
        [XmlElement("tag_position_id")]
        public string TagPositionId { get; set; }
    }
}
