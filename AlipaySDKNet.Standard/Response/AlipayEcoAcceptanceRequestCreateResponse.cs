using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoAcceptanceRequestCreateResponse.
    /// </summary>
    public class AlipayEcoAcceptanceRequestCreateResponse : AopResponse
    {
        /// <summary>
        /// 提交数据ID
        /// </summary>
        [XmlElement("request_id")]
        public long RequestId { get; set; }

        /// <summary>
        /// 结果记录条数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
