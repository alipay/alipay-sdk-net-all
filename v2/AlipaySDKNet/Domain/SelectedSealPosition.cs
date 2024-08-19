using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SelectedSealPosition Data Structure.
    /// </summary>
    [Serializable]
    public class SelectedSealPosition : AopObject
    {
        /// <summary>
        /// 用印对齐类型
        /// </summary>
        [XmlElement("location_type")]
        public string LocationType { get; set; }

        /// <summary>
        /// 正文章页码，页
        /// </summary>
        [XmlElement("main_body_page")]
        public long MainBodyPage { get; set; }

        /// <summary>
        /// 签署区横坐标，px
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 签署区位置纵坐标，px
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }

        /// <summary>
        /// 签章区域
        /// </summary>
        [XmlElement("position_type")]
        public long PositionType { get; set; }

        /// <summary>
        /// 印模高度，毫米
        /// </summary>
        [XmlElement("seal_height")]
        public long SealHeight { get; set; }

        /// <summary>
        /// 印模宽度，毫米
        /// </summary>
        [XmlElement("seal_width")]
        public long SealWidth { get; set; }
    }
}
