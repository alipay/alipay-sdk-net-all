using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingImagedirectoryCreateResponse.
    /// </summary>
    public class AlipayMarketingImagedirectoryCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建后的目录id。
        /// </summary>
        [XmlElement("image_directory_id")]
        public string ImageDirectoryId { get; set; }
    }
}
