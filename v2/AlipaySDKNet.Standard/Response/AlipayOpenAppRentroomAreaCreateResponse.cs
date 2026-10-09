using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppRentroomAreaCreateResponse.
    /// </summary>
    public class AlipayOpenAppRentroomAreaCreateResponse : AopResponse
    {
        /// <summary>
        /// 平台生成的小区ID
        /// </summary>
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 小区信息提报时商户传入的小区ID，不做加工直接返回。
        /// </summary>
        [XmlElement("out_area_id")]
        public string OutAreaId { get; set; }
    }
}
