using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdMateriallibraryAddResponse.
    /// </summary>
    public class AlipayDataDataserviceAdMateriallibraryAddResponse : AopResponse
    {
        /// <summary>
        /// 视频时长
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 文件高
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 素材类型，1图片，2视频
        /// </summary>
        [XmlElement("material_type")]
        public long MaterialType { get; set; }

        /// <summary>
        /// 素材值
        /// </summary>
        [XmlElement("material_value")]
        public string MaterialValue { get; set; }

        /// <summary>
        /// 文件大小，单位kb
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 素材来源
        /// </summary>
        [XmlElement("source")]
        public long Source { get; set; }

        /// <summary>
        /// 素材状态：0有效，1无效
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        [XmlElement("upload_time")]
        public string UploadTime { get; set; }

        /// <summary>
        /// 素材库id
        /// </summary>
        [XmlElement("user_material_lib_id")]
        public string UserMaterialLibId { get; set; }

        /// <summary>
        /// 文件宽
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
