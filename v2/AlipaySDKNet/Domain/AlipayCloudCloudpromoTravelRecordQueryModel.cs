using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelRecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoTravelRecordQueryModel : AopObject
    {
        /// <summary>
        /// 游历记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 等同appid
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 来源客户
        /// </summary>
        [XmlElement("source_u_id")]
        public string SourceUId { get; set; }
    }
}
