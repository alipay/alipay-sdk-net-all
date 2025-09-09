using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRecordQueryComponents Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRecordQueryComponents : AopObject
    {
        /// <summary>
        /// 权益流水查询组件
        /// </summary>
        [XmlElement("luck_draw_record_query_component")]
        public BenefitRecordQueryComponent LuckDrawRecordQueryComponent { get; set; }
    }
}
