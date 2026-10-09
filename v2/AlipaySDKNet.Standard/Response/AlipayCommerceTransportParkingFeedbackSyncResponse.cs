using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingFeedbackSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingFeedbackSyncResponse : AopResponse
    {
        /// <summary>
        /// 具体错误原因编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 具体错误描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }
    }
}
