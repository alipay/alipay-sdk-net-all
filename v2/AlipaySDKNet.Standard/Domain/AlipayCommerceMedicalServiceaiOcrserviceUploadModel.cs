using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiOcrserviceUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceaiOcrserviceUploadModel : AopObject
    {
        /// <summary>
        /// 域内系统图像afts id
        /// </summary>
        [XmlElement("afts_id")]
        public string AftsId { get; set; }

        /// <summary>
        /// 文件类型，图像、语音、视频、其他
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 域外系统图像id，如果是域外场景，必填
        /// </summary>
        [XmlElement("out_pic_id")]
        public string OutPicId { get; set; }

        /// <summary>
        /// 域外系统图像地址，如果是域外场景，必填
        /// </summary>
        [XmlElement("out_pic_url")]
        public string OutPicUrl { get; set; }

        /// <summary>
        /// 域内系统图像url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 是否重试解析任务
        /// </summary>
        [XmlElement("retry_parsing_task")]
        public bool RetryParsingTask { get; set; }

        /// <summary>
        /// 系统类型，域内、好大夫
        /// </summary>
        [XmlElement("system_type")]
        public string SystemType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户类型，支付宝uid、其他uid
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
