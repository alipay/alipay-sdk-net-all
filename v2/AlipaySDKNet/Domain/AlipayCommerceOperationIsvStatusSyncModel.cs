using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIsvStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationIsvStatusSyncModel : AopObject
    {
        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务子类型 PICK_UP = 自提 TAKE_AWAY = 外卖 QUEUE = 排队
        /// </summary>
        [XmlElement("service_sub_type")]
        public string ServiceSubType { get; set; }

        /// <summary>
        /// 商家服务状态枚举：OFFLINE("OFFLINE","下线状态")， IN_BUSINESS("IN_BUSINESS","营业中"),BUSY("BUSY","繁忙"),RESTING("RESTING","休息中"),RECEPTION_RESERVATION("RECEPTION_RESERVATION","接收预定");
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商家门店id（ISV内部门店唯一编号）
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
