using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMultimediaXnnminiModelCreateResponse.
    /// </summary>
    public class AlipayMultimediaXnnminiModelCreateResponse : AopResponse
    {
        /// <summary>
        /// 模型id
        /// </summary>
        [XmlElement("model_id")]
        public string ModelId { get; set; }
    }
}
