using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageDeliveryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMessageDeliveryQueryModel : AopObject
    {
        /// <summary>
        /// 智能触达查询条件
        /// </summary>
        [XmlElement("query_criteria")]
        public QueryCriteria QueryCriteria { get; set; }

        /// <summary>
        /// 智能触达时记录ID，用于查询触达结果
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
