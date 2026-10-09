using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdexportCreateResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdexportCreateResponse : AopResponse
    {
        /// <summary>
        /// 导出任务流水号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }
    }
}
