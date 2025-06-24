using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocationAuthConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class LocationAuthConfigVO : AopObject
    {
        /// <summary>
        /// 配置开关 true|false
        /// </summary>
        [XmlElement("lbs_switch")]
        public bool LbsSwitch { get; set; }
    }
}
