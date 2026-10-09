using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeDeleteResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeDeleteResponse : AopResponse
    {
        /// <summary>
        /// 批量删除创意的响应
        /// </summary>
        [XmlElement("open_delete_creative_response")]
        public OpenDeleteCreativeResponse OpenDeleteCreativeResponse { get; set; }
    }
}
