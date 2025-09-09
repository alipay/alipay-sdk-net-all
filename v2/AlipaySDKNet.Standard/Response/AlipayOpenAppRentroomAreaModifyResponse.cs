using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppRentroomAreaModifyResponse.
    /// </summary>
    public class AlipayOpenAppRentroomAreaModifyResponse : AopResponse
    {
        /// <summary>
        /// 小区ID
        /// </summary>
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 商户侧自定义小区ID
        /// </summary>
        [XmlElement("out_area_id")]
        public string OutAreaId { get; set; }
    }
}
