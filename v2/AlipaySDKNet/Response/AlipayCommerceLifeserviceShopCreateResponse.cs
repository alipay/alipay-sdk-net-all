using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopCreateResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceShopCreateResponse : AopResponse
    {
        /// <summary>
        /// 副本业务ID
        /// </summary>
        [XmlElement("copy_id")]
        public string CopyId { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 正本ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
