using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignedCrossResult Data Structure.
    /// </summary>
    [Serializable]
    public class SignedCrossResult : AopObject
    {
        /// <summary>
        /// 骑缝章签署区位置横坐标，px
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 骑缝章签署区位置纵坐标，px
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }

        /// <summary>
        /// 印模高度，毫米
        /// </summary>
        [XmlElement("seal_height")]
        public long SealHeight { get; set; }

        /// <summary>
        /// 印模id
        /// </summary>
        [XmlElement("seal_id")]
        public string SealId { get; set; }

        /// <summary>
        /// 印模osskey
        /// </summary>
        [XmlElement("seal_impression")]
        public string SealImpression { get; set; }

        /// <summary>
        /// 印模宽度，毫米
        /// </summary>
        [XmlElement("seal_width")]
        public long SealWidth { get; set; }
    }
}
