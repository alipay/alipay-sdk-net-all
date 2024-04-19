using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantOrderStoreSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantOrderStoreSyncModel : AopObject
    {
        /// <summary>
        /// 状态相关的描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 状态类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 订单的ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 插件业务场景code，预约为ShopService
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 线上店的ID
        /// </summary>
        [XmlElement("store_open_id")]
        public string StoreOpenId { get; set; }
    }
}
