using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingExitinfoSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingExitinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 具体错误码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 具体错误原因
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }
    }
}
