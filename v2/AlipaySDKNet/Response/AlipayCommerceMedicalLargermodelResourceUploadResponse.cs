using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelResourceUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelResourceUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片或文件存储在afts的标识
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
