using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSystemCrossPageRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CaSystemCrossPageRequest : AopObject
    {
        /// <summary>
        /// defaultCrossPageRule = true  默认设置每五页盖一次
        /// </summary>
        [XmlElement("default_cross_page")]
        public long DefaultCrossPage { get; set; }

        /// <summary>
        /// 是否采取系统默认骑缝章用印规则
        /// </summary>
        [XmlElement("default_cross_page_rule")]
        public bool DefaultCrossPageRule { get; set; }

        /// <summary>
        /// 结束页码（供骑缝章使用）
        /// </summary>
        [XmlElement("pos_page_end")]
        public long PosPageEnd { get; set; }

        /// <summary>
        /// 签署页码
        /// </summary>
        [XmlElement("pos_page_start")]
        public long PosPageStart { get; set; }

        /// <summary>
        /// 签署区位置横坐标
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 签署区位置纵坐标
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }

        /// <summary>
        /// 骑缝章用印次数，默认一次
        /// </summary>
        [XmlElement("seal_times")]
        public long SealTimes { get; set; }
    }
}
