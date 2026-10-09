using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwSpuSyncResponse.
    /// </summary>
    public class AlipayIserviceCcmSwSpuSyncResponse : AopResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
