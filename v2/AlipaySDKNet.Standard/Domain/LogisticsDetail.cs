using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsDetail : AopObject
    {
        /// <summary>
        /// 物流类型
        /// </summary>
        [XmlElement("logistics_type")]
        public string LogisticsType { get; set; }
    }
}
