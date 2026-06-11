using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryQueryOption Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryQueryOption : AopObject
    {
        /// <summary>
        /// 是否在出参中返回门店的油品信息列表
        /// </summary>
        [XmlElement("include_oil_product")]
        public bool IncludeOilProduct { get; set; }
    }
}
