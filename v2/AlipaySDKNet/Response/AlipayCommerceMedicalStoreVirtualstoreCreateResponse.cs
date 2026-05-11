using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalStoreVirtualstoreCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalStoreVirtualstoreCreateResponse : AopResponse
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("store_id")]
        public long StoreId { get; set; }
    }
}
