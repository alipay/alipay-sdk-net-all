using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboSeatHeatingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboSeatHeatingInfo : AopObject
    {
        /// <summary>
        /// 座椅加热档位信息
        /// </summary>
        [XmlElement("current_level")]
        public RoboCurrentLevel CurrentLevel { get; set; }

        /// <summary>
        /// 是否有座椅加热能力，0无，1有
        /// </summary>
        [XmlElement("heating_ability")]
        public long HeatingAbility { get; set; }
    }
}
