using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGpStoreidQueryResponse.
    /// </summary>
    public class AlipayMerchantGpStoreidQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家店铺id，用于调用神券的业务接口
        /// </summary>
        [XmlElement("a_store_id")]
        public string AStoreId { get; set; }
    }
}
