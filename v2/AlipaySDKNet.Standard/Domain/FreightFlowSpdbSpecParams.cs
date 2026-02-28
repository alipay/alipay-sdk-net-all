using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreightFlowSpdbSpecParams Data Structure.
    /// </summary>
    [Serializable]
    public class FreightFlowSpdbSpecParams : AopObject
    {
        /// <summary>
        /// 交易地区代码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }
    }
}
