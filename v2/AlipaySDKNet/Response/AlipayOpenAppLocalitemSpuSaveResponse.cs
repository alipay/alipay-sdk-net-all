using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppLocalitemSpuSaveResponse.
    /// </summary>
    public class AlipayOpenAppLocalitemSpuSaveResponse : AopResponse
    {
        /// <summary>
        /// 标品id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
