using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetCreateResponse.
    /// </summary>
    public class AlipayCommerceIotSupplierAssetCreateResponse : AopResponse
    {
        /// <summary>
        /// 记录id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
