using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SealRequestInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SealRequestInfo : AopObject
    {
        /// <summary>
        /// 图章对齐位置的x坐标自
        /// </summary>
        [XmlElement("axis_x")]
        public long AxisX { get; set; }

        /// <summary>
        /// 图章用印位置的y坐标
        /// </summary>
        [XmlElement("axis_y")]
        public long AxisY { get; set; }

        /// <summary>
        /// 电子图章对齐方式，目前只支持TOP_LEFT，在此顶一下图章用印位置的取值方式为，图章左上角相对原点（PDF左上角）的坐标
        /// </summary>
        [XmlElement("location_type")]
        public string LocationType { get; set; }

        /// <summary>
        /// 图章旋转角度，取值范围为-360到360，正数为顺时针旋转，负数为逆时针旋转
        /// </summary>
        [XmlElement("rotate_angle")]
        public long RotateAngle { get; set; }

        /// <summary>
        /// 需要使用的印章id，需要与法务中台技术确认值
        /// </summary>
        [XmlElement("seal_id")]
        public long SealId { get; set; }
    }
}
