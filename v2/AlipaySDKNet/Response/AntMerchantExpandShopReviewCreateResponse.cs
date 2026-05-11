using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandShopReviewCreateResponse.
    /// </summary>
    public class AntMerchantExpandShopReviewCreateResponse : AopResponse
    {
        /// <summary>
        /// 同步时间
        /// </summary>
        [XmlElement("sync_time")]
        public string SyncTime { get; set; }
    }
}
