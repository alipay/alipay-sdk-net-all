using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIcpMediaUploadResponse.
    /// </summary>
    public class AlipayOpenMiniIcpMediaUploadResponse : AopResponse
    {
        /// <summary>
        /// 申请备案时填写的文件材料凭证ID
        /// </summary>
        [XmlElement("media_id")]
        public string MediaId { get; set; }
    }
}
