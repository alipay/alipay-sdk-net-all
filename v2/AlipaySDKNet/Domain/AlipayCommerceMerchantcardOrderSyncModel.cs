using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardOrderSyncModel : AopObject
    {
        /// <summary>
        /// 推送批次号，由外部传入，用于标识是哪一次推送任务
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 售卖订单数据列表
        /// </summary>
        [XmlArray("order_data_list")]
        [XmlArrayItem("order_data_sync_request")]
        public List<OrderDataSyncRequest> OrderDataList { get; set; }

        /// <summary>
        /// 同步类型，用于区分是增量同步还是存量同步
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }
    }
}
