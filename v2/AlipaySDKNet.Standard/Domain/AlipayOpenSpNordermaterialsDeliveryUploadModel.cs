using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsDeliveryUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsDeliveryUploadModel : AopObject
    {
        /// <summary>
        /// 门店物料收货地址
        /// </summary>
        [XmlElement("delivery_address")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 需要发出的门店的物料个数，单位个
        /// </summary>
        [XmlElement("materials_count")]
        public long MaterialsCount { get; set; }

        /// <summary>
        /// 生产单号
        /// </summary>
        [XmlElement("production_order_no")]
        public string ProductionOrderNo { get; set; }

        /// <summary>
        /// 门店物料收货人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人联系电话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 门店单号，用于区分生产单号下的门店物料，与此前查询的对应
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }

        /// <summary>
        /// 门店下物流发出的物流单号
        /// </summary>
        [XmlElement("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
