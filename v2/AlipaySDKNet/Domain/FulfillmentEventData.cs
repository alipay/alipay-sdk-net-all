using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentEventData Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentEventData : AopObject
    {
        /// <summary>
        /// 检查检验类事件数据
        /// </summary>
        [XmlElement("examination")]
        public ExaminationEventParam Examination { get; set; }
    }
}
