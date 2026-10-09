using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentCommercialStoreitemDeleteResponse.
    /// </summary>
    public class AlipayContentCommercialStoreitemDeleteResponse : AopResponse
    {
        /// <summary>
        /// 带货车商品移除
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
