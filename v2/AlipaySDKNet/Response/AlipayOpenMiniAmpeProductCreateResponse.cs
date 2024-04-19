using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductCreateResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeProductCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建成功生成的productId
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
