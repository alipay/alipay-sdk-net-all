using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignAreaRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SignAreaRequest : AopObject
    {
        /// <summary>
        /// 签署页码，印章实际用印的页码
        /// </summary>
        [XmlElement("pos_page")]
        public long PosPage { get; set; }

        /// <summary>
        /// 签署区位置横坐标，单位为像素。以左上角为坐标原点，向右为x轴，一般文件为A4格式(分辨率72像素)，图像像素为595x842（宽595高842），指定x坐标即可指定横坐标位置用印
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 签署区位置纵坐标，单位为像素。以左上角为坐标原点，向下为y轴，一般文件为A4格式(分辨率72像素)，图像像素为595x842（宽595高842），y轴坐标即可指定纵坐标位置用印
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }
    }
}
