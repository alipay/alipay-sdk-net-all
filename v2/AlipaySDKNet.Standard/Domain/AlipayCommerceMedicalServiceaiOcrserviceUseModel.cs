using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiOcrserviceUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceaiOcrserviceUseModel : AopObject
    {
        /// <summary>
        /// 域内系统图像afts id
        /// </summary>
        [XmlElement("afts_id")]
        public string AftsId { get; set; }

        /// <summary>
        /// 文件格式
        /// </summary>
        [XmlElement("file_ext")]
        public string FileExt { get; set; }

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
        /// 好大夫id
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

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
        /// 资源
        /// </summary>
        [XmlElement("source_system")]
        public string SourceSystem { get; set; }

        /// <summary>
        /// 用户l
        /// </summary>
        [XmlElement("user_identity")]
        public string UserIdentity { get; set; }
    }
}
