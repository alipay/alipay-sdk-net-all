using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiOcrserviceUseResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceaiOcrserviceUseResponse : AopResponse
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
        /// 任务
        /// </summary>
        [XmlElement("task_category")]
        public string TaskCategory { get; set; }
    }
}
