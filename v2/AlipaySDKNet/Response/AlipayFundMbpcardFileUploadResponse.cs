using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardFileUploadResponse.
    /// </summary>
    public class AlipayFundMbpcardFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 影像文件存储平台的标识
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 支持OCR识别的内容反显
        /// </summary>
        [XmlArray("ocr_data")]
        [XmlArrayItem("ocr_data")]
        public List<OcrData> OcrData { get; set; }
    }
}
