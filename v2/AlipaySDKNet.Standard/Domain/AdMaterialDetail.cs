using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdMaterialDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AdMaterialDetail : AopObject
    {
        /// <summary>
        /// 播放时长，单位ms
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 素材高度，单位px
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 素材类型，1图片2视频
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
        /// 素材状态 0有效，1已删除
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 上传时间，重复上传会覆盖
        /// </summary>
        [XmlElement("upload_time")]
        public string UploadTime { get; set; }

        /// <summary>
        /// 素材库id
        /// </summary>
        [XmlElement("user_material_lib_id")]
        public string UserMaterialLibId { get; set; }

        /// <summary>
        /// 素材宽度，单位px
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
