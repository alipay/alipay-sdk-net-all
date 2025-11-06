using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleOrderOpenApiRes Data Structure.
    /// </summary>
    [Serializable]
    public class SaleOrderOpenApiRes : AopObject
    {
        /// <summary>
        /// 实际发货时间
        /// </summary>
        [XmlElement("actual_delivery_time")]
        public string ActualDeliveryTime { get; set; }

        /// <summary>
        /// 履约单号，即AO单号
        /// </summary>
        [XmlElement("combine_number")]
        public string CombineNumber { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("delivery_address")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// 发货完成时间
        /// </summary>
        [XmlElement("delivery_finish_time")]
        public string DeliveryFinishTime { get; set; }

        /// <summary>
        /// 已发货的物料数量
        /// </summary>
        [XmlElement("delivery_materials_count")]
        public long DeliveryMaterialsCount { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_attr_list")]
        [XmlArrayItem("ext_attribute_info")]
        public List<ExtAttributeInfo> ExtAttrList { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlArray("logistics_facade_responses")]
        [XmlArrayItem("logistics_facade_response")]
        public List<LogisticsFacadeResponse> LogisticsFacadeResponses { get; set; }

        /// <summary>
        /// 物料数量，单位个
        /// </summary>
        [XmlElement("materials_total")]
        public long MaterialsTotal { get; set; }

        /// <summary>
        /// 订单id，即SO号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 生产完成时间
        /// </summary>
        [XmlElement("produce_finish_time")]
        public string ProduceFinishTime { get; set; }

        /// <summary>
        /// 已生产物料数量
        /// </summary>
        [XmlElement("production_materials_count")]
        public string ProductionMaterialsCount { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }
    }
}
