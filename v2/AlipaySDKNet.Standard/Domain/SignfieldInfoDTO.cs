using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignfieldInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SignfieldInfoDTO : AopObject
    {
        /// <summary>
        /// 文件ID,调用文件上传接口返回的fileId
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 是否为自由签署区(自由签署区可拖动)，自由签署区时，不可填写xy坐标
        /// </summary>
        [XmlElement("free_sign")]
        public bool FreeSign { get; set; }

        /// <summary>
        /// 普通签署区为签署页码，骑缝签署区为起始页码
        /// </summary>
        [XmlElement("pos_page")]
        public long PosPage { get; set; }

        /// <summary>
        /// 普通签署区为空，骑缝签署区为结束页码
        /// </summary>
        [XmlElement("pos_page_end")]
        public long PosPageEnd { get; set; }

        /// <summary>
        /// 签署区位置横坐标，骑缝签署区为空，普通签署区必填
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 签署区位置纵坐标
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }

        /// <summary>
        /// 签署位置类型，1-普通，2-骑缝，默认1
        /// </summary>
        [XmlElement("position_type")]
        public long PositionType { get; set; }

        /// <summary>
        /// 签署区类型，1-系统签署，2-手动签署
        /// </summary>
        [XmlElement("sign_area_type")]
        public string SignAreaType { get; set; }
    }
}
