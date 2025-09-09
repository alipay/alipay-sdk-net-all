using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocationAuthConfigQueryVO Data Structure.
    /// </summary>
    [Serializable]
    public class LocationAuthConfigQueryVO : AopObject
    {
        /// <summary>
        /// 配置开关
        /// </summary>
        [XmlElement("lbs_switch")]
        public bool LbsSwitch { get; set; }
    }
}
