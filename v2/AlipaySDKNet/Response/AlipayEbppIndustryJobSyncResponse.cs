using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryJobSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧岗位唯一标识，请求正常处理的情况下，此参数必传。
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }
    }
}
