using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappBrandUploadResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappBrandUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片上传成功后的图片存储键(可用于填写调用alipay.open.mini.miniapp.brand.submit时需要的图片类型的字段)
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }
    }
}
