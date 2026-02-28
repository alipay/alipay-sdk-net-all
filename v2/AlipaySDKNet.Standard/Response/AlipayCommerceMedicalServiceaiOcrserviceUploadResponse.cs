using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiOcrserviceUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceaiOcrserviceUploadResponse : AopResponse
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
        /// kv抽取结果，map<String, String> 结构
        /// </summary>
        [XmlElement("kv_result")]
        public string KvResult { get; set; }

        /// <summary>
        /// ocr 处理结果
        /// </summary>
        [XmlElement("ocr_result")]
        public string OcrResult { get; set; }

        /// <summary>
        /// 地址，如果是域外场景，必填
        /// </summary>
        [XmlElement("out_pic_url")]
        public string OutPicUrl { get; set; }

        /// <summary>
        /// 域内系统图像url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 任务类型，病历、处方、检查、检验、体检、其他
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
