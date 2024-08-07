using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdMaterialQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdMaterialQueryResponse : AopResponse
    {
        /// <summary>
        /// 物料上传结果详情
        /// </summary>
        [XmlElement("material_upload_detail")]
        public MaterialUploadDetail MaterialUploadDetail { get; set; }
    }
}
