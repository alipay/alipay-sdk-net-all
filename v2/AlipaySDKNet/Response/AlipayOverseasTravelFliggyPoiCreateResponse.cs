using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelFliggyPoiCreateResponse.
    /// </summary>
    public class AlipayOverseasTravelFliggyPoiCreateResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误消息提示
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 回调结果的结果标示
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
