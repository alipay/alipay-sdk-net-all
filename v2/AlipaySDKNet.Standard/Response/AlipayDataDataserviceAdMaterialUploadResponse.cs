using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdMaterialUploadResponse.
    /// </summary>
    public class AlipayDataDataserviceAdMaterialUploadResponse : AopResponse
    {
        /// <summary>
        /// 广告投放平台生成的物料实例ID
        /// </summary>
        [XmlElement("material_instance_id")]
        public long MaterialInstanceId { get; set; }
    }
}
