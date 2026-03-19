using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSystemCrossPage Data Structure.
    /// </summary>
    [Serializable]
    public class CaSystemCrossPage : AopObject
    {
        /// <summary>
        /// 默认骑缝章页数
        /// </summary>
        [XmlElement("default_cross_page")]
        public long DefaultCrossPage { get; set; }

        /// <summary>
        /// 是否采取系统默认骑缝章用印规则
        /// </summary>
        [XmlElement("default_cross_page_rule")]
        public bool DefaultCrossPageRule { get; set; }

        /// <summary>
        /// 签署结束页码
        /// </summary>
        [XmlElement("pos_page_end")]
        public long PosPageEnd { get; set; }

        /// <summary>
        /// 签署开始页码
        /// </summary>
        [XmlElement("pos_page_start")]
        public long PosPageStart { get; set; }

        /// <summary>
        /// 签署区位置横坐标，单位点（point）
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 签署区位置纵坐标，单位点（point）
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }

        /// <summary>
        /// 用印次数
        /// </summary>
        [XmlElement("seal_times")]
        public long SealTimes { get; set; }
    }
}
