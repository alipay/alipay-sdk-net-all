using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizUnitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizUnitInfo : AopObject
    {
        /// <summary>
        /// 经营单元id，如店铺id
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 经营单元名称，如店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 经营单元类型，如口碑门店/集团统一门店等
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
