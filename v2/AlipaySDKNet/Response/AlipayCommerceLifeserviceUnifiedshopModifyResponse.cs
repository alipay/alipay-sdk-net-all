using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceUnifiedshopModifyResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceUnifiedshopModifyResponse : AopResponse
    {
        /// <summary>
        /// 副本业务ID
        /// </summary>
        [XmlElement("copy_id")]
        public string CopyId { get; set; }

        /// <summary>
        /// 更新后状态：UPDATING-更新中 / AUDITING-审核中 / PASS-审核通过
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店主键ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
