using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboFrontLightInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboFrontLightInfo : AopObject
    {
        /// <summary>
        /// 当前车前灯的类型，枚举1-6，为0则是没开启
        /// </summary>
        [XmlElement("current_type")]
        public long CurrentType { get; set; }

        /// <summary>
        /// 车前灯动画视频url
        /// </summary>
        [XmlElement("gif_in")]
        public string GifIn { get; set; }

        /// <summary>
        /// 车前灯动画视频url
        /// </summary>
        [XmlElement("gif_out")]
        public string GifOut { get; set; }

        /// <summary>
        /// 是否有车前灯能力，0无，1有
        /// </summary>
        [XmlElement("light_ability")]
        public long LightAbility { get; set; }

        /// <summary>
        /// 最近一次设置的版本号
        /// </summary>
        [XmlElement("light_version")]
        public long LightVersion { get; set; }

        /// <summary>
        /// 剩余修改次数
        /// </summary>
        [XmlElement("remain_modify_num")]
        public long RemainModifyNum { get; set; }
    }
}
