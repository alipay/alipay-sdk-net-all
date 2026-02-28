using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboCarWindowInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboCarWindowInfo : AopObject
    {
        /// <summary>
        /// 车窗开启状态：1关闭，2开启
        /// </summary>
        [XmlElement("open_status")]
        public long OpenStatus { get; set; }

        /// <summary>
        /// 是否有车窗能力，0无，1有
        /// </summary>
        [XmlElement("window_ability")]
        public long WindowAbility { get; set; }
    }
}
