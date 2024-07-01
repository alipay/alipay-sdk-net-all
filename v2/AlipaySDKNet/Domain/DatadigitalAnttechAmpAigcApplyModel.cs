using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechAmpAigcApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechAmpAigcApplyModel : AopObject
    {
        /// <summary>
        /// 生成图片或视频的文本或文件id
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备id类型
        /// </summary>
        [XmlElement("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 像素高
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// aigc模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 参数数据
        /// </summary>
        [XmlElement("param_data")]
        public string ParamData { get; set; }

        /// <summary>
        /// 系统幂等请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 企业社会信用代码
        /// </summary>
        [XmlElement("social_code")]
        public string SocialCode { get; set; }

        /// <summary>
        /// 风格
        /// </summary>
        [XmlElement("style")]
        public string Style { get; set; }

        /// <summary>
        /// 像素宽
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
