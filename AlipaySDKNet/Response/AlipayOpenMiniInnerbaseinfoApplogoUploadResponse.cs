using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoApplogoUploadResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoApplogoUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传图片结果地址
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }
    }
}
