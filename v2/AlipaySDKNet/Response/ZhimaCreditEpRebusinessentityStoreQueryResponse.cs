using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRebusinessentityStoreQueryResponse.
    /// </summary>
    public class ZhimaCreditEpRebusinessentityStoreQueryResponse : AopResponse
    {
        /// <summary>
        /// 关系数据集
        /// </summary>
        [XmlElement("data")]
        public RebusinessEntityRelation Data { get; set; }

        /// <summary>
        /// 店铺平台ID
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
