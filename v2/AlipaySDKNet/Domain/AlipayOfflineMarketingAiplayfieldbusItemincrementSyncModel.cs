using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingAiplayfieldbusItemincrementSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingAiplayfieldbusItemincrementSyncModel : AopObject
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlElement("item_list")]
        public string ItemList { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
