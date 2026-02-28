using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboWelcomeLightInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboWelcomeLightInfo : AopObject
    {
        /// <summary>
        /// 是否有迎宾灯能力，0无，1有
        /// </summary>
        [XmlElement("light_ability")]
        public long LightAbility { get; set; }

        /// <summary>
        /// 迎宾灯颜色
        /// </summary>
        [XmlElement("light_color")]
        public string LightColor { get; set; }
    }
}
