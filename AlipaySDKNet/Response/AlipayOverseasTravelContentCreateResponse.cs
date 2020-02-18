using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelContentCreateResponse.
    /// </summary>
    public class AlipayOverseasTravelContentCreateResponse : AopResponse
    {
        /// <summary>
        /// 可选，仅当请求中的modified_date等于已落地内容的modified_date并且内容状态一致，认为幂等成功，返回Success
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
