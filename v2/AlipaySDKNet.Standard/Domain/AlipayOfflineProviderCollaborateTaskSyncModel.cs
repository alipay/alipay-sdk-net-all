using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateTaskSyncModel : AopObject
    {
        /// <summary>
        /// 商家是否完成交付
        /// </summary>
        [XmlElement("delivery_completed")]
        public string DeliveryCompleted { get; set; }

        /// <summary>
        /// 商家完成交付日期
        /// </summary>
        [XmlElement("delivery_completion_date")]
        public string DeliveryCompletionDate { get; set; }

        /// <summary>
        /// 商家首次动销日期
        /// </summary>
        [XmlElement("first_sales_date")]
        public string FirstSalesDate { get; set; }

        /// <summary>
        /// 是否有点单笔数
        /// </summary>
        [XmlElement("order_transaction")]
        public string OrderTransaction { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [XmlElement("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 商家是否连接打印机
        /// </summary>
        [XmlElement("printer_connected")]
        public string PrinterConnected { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 任务单号leads_id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 商家上传商品数量
        /// </summary>
        [XmlElement("uploaded_product_count")]
        public long UploadedProductCount { get; set; }
    }
}
