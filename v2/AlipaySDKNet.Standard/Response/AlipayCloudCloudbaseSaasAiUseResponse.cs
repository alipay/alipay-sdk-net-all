using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseSaasAiUseResponse.
    /// </summary>
    public class AlipayCloudCloudbaseSaasAiUseResponse : AopResponse
    {
        /// <summary>
        /// 返回OCR结果数据，即返回图片中识别出来的文字内容，具体内容由上传图片决定
        /// </summary>
        [XmlElement("result_str")]
        public string ResultStr { get; set; }
    }
}
