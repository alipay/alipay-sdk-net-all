using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelContentCountSyncResponse.
    /// </summary>
    public class AlipayOverseasTravelContentCountSyncResponse : AopResponse
    {
        /// <summary>
        /// 详细错误码。可选，当code=40004，sub_code=BUSINESS_ERROR，不为为空
        /// </summary>
        [XmlElement("results")]
        public string Results { get; set; }
    }
}
