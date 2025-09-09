using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayIotNfcpointUploadResponse.
    /// </summary>
    public class AlipayPayIotNfcpointUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件素材id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("material_url")]
        public string MaterialUrl { get; set; }
    }
}
