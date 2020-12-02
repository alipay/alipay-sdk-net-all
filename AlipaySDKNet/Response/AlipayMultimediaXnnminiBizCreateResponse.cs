using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMultimediaXnnminiBizCreateResponse.
    /// </summary>
    public class AlipayMultimediaXnnminiBizCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
