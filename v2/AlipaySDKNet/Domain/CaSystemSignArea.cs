using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSystemSignArea Data Structure.
    /// </summary>
    [Serializable]
    public class CaSystemSignArea : AopObject
    {
        /// <summary>
        /// 骑缝章信息
        /// </summary>
        [XmlElement("ca_system_cross_page")]
        public CaSystemCrossPage CaSystemCrossPage { get; set; }

        /// <summary>
        /// 正文章信息
        /// </summary>
        [XmlElement("ca_system_main_body")]
        public CaSystemMainBody CaSystemMainBody { get; set; }

        /// <summary>
        /// 指定外部印章类型的预设位置
        /// </summary>
        [XmlElement("external_seal_type")]
        public string ExternalSealType { get; set; }

        /// <summary>
        /// 用印对齐类型
        /// </summary>
        [XmlElement("location_type")]
        public string LocationType { get; set; }

        /// <summary>
        /// 1代表正文章，2代表骑缝章
        /// </summary>
        [XmlElement("position_type")]
        public long PositionType { get; set; }

        /// <summary>
        /// 章的旋转角度，单位是度（°）
        /// </summary>
        [XmlElement("rotate_angle")]
        public long RotateAngle { get; set; }

        /// <summary>
        /// 印章高度，单位mm
        /// </summary>
        [XmlElement("seal_height")]
        public long SealHeight { get; set; }

        /// <summary>
        /// 印章id
        /// </summary>
        [XmlElement("seal_id")]
        public string SealId { get; set; }

        /// <summary>
        /// sealId，sealPicAddr二选一
        /// </summary>
        [XmlElement("seal_pic_addr")]
        public string SealPicAddr { get; set; }

        /// <summary>
        /// 印章宽度，单位mm
        /// </summary>
        [XmlElement("seal_width")]
        public long SealWidth { get; set; }
    }
}
