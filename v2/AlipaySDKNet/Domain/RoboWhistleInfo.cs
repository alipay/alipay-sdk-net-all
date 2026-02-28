using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboWhistleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboWhistleInfo : AopObject
    {
        /// <summary>
        /// 是否有鸣笛能力，0无，1有
        /// </summary>
        [XmlElement("whistle_ability")]
        public long WhistleAbility { get; set; }
    }
}
