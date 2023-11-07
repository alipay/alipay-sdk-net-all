using System;
using System.Xml.Serialization;

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
    }
}
