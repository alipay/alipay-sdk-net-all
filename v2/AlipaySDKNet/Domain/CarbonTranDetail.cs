using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarbonTranDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CarbonTranDetail : AopObject
    {
        /// <summary>
        /// 绿色场景类型
        /// </summary>
        [XmlElement("carbon_type")]
        public string CarbonType { get; set; }

        /// <summary>
        /// 能量值
        /// </summary>
        [XmlElement("carbon_value")]
        public string CarbonValue { get; set; }
    }
}
