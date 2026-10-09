using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHdfaitransferPictureocrIdentifyResponse.
    /// </summary>
    public class AlipayCommerceHdfaitransferPictureocrIdentifyResponse : AopResponse
    {
        /// <summary>
        /// ocr识别结果，结果中包含制表符\t和换行符\n
        /// </summary>
        [XmlElement("ocr_result")]
        public string OcrResult { get; set; }
    }
}
