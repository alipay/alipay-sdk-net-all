using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceUtcActivitySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceUtcActivitySyncModel : AopObject
    {
        /// <summary>
        /// 业务ID，需回传同步接口的业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 支付宝侧零售商活动id
        /// </summary>
        [XmlElement("retailer_activity_id")]
        public string RetailerActivityId { get; set; }

        /// <summary>
        /// 本次同步的门店结果数据
        /// </summary>
        [XmlArray("store_list")]
        [XmlArrayItem("bs_store")]
        public List<BsStore> StoreList { get; set; }
    }
}
