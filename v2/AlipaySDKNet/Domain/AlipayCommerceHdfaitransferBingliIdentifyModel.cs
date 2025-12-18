using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHdfaitransferBingliIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHdfaitransferBingliIdentifyModel : AopObject
    {
        /// <summary>
        /// OCR文本内容
        /// </summary>
        [XmlElement("ocr_content")]
        public string OcrContent { get; set; }

        /// <summary>
        /// 调用该接口的场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
