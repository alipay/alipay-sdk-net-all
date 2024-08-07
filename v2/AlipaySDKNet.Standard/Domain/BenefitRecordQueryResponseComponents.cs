using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRecordQueryResponseComponents Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRecordQueryResponseComponents : AopObject
    {
        /// <summary>
        /// 权益流水查询组件
        /// </summary>
        [XmlElement("luck_draw_record_query_component")]
        public BenefitRecordQueryResponseComponent LuckDrawRecordQueryComponent { get; set; }
    }
}
