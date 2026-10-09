using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosOrderUploadResponse.
    /// </summary>
    public class KoubeiCateringPosOrderUploadResponse : AopResponse
    {
        /// <summary>
        /// 生成序列号标记每次上传
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
