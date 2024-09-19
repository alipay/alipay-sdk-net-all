using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopDeliveryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopDeliveryInfo : AopObject
    {
        /// <summary>
        /// 发货物流状态
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流的物料数量，单位 个
        /// </summary>
        [XmlElement("materials_num")]
        public long MaterialsNum { get; set; }

        /// <summary>
        /// 快递物流单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
