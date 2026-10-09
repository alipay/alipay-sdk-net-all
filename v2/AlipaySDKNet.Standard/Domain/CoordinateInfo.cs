using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CoordinateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CoordinateInfo : AopObject
    {
        /// <summary>
        /// 识别信息内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 结束点横坐标，单位px
        /// </summary>
        [XmlElement("end_x")]
        public string EndX { get; set; }

        /// <summary>
        /// 结束点纵坐标，单位px
        /// </summary>
        [XmlElement("end_y")]
        public string EndY { get; set; }

        /// <summary>
        /// 起始点横坐标，单位px
        /// </summary>
        [XmlElement("start_x")]
        public string StartX { get; set; }

        /// <summary>
        /// 起始点纵坐标，单位px
        /// </summary>
        [XmlElement("start_y")]
        public string StartY { get; set; }
    }
}
