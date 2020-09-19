using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAntestReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAntestReportQueryModel : AopObject
    {
        /// <summary>
        /// 测试任务id
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
