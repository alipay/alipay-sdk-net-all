using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WelfareForestPersonWaterDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WelfareForestPersonWaterDTO : AopObject
    {
        /// <summary>
        /// 用户浇水次数，Long类型
        /// </summary>
        [XmlElement("user_water_count")]
        public long UserWaterCount { get; set; }

        /// <summary>
        /// 用户参与的排名，Long类型。如果公益林没有配置排名功能，固定返回为0，直接忽略该字段。
        /// </summary>
        [XmlElement("user_water_placing")]
        public long UserWaterPlacing { get; set; }

        /// <summary>
        /// 用户浇水能量值，long类型
        /// </summary>
        [XmlElement("user_water_sum")]
        public long UserWaterSum { get; set; }
    }
}
