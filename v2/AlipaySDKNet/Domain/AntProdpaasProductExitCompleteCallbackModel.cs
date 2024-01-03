using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntProdpaasProductExitCompleteCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasProductExitCompleteCallbackModel : AopObject
    {
        /// <summary>
        /// 实发商品数量
        /// </summary>
        [XmlElement("actual_qty")]
        public long ActualQty { get; set; }

        /// <summary>
        /// 批次编号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 支持出库单多次发货 0 表示入库单最终状态确认; 1 表示入库单中间状态确认；
        /// </summary>
        [XmlElement("confirm_type")]
        public long ConfirmType { get; set; }

        /// <summary>
        /// 出库单信息
        /// </summary>
        [XmlElement("delivery_order_code")]
        public string DeliveryOrderCode { get; set; }

        /// <summary>
        /// 过期日期
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 供应链商品属性集合
        /// </summary>
        [XmlArray("extend_pros")]
        [XmlArrayItem("supplier_item_attr_field")]
        public List<SupplierItemAttrField> ExtendPros { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("logistics_info")]
        public SupplierLogisticsInfo LogisticsInfo { get; set; }

        /// <summary>
        /// 出库单类型,生产直发-DIRECT_PRODUCE,生产备货-PRODUCE_STOCK, 仓库发货- STOCK_DELIVERY, 仓仓调拨 - STOCK_TRANSFER
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 计划发货数量
        /// </summary>
        [XmlElement("plan_qty")]
        public long PlanQty { get; set; }

        /// <summary>
        /// 生产批号
        /// </summary>
        [XmlElement("produce_code")]
        public string ProduceCode { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [XmlElement("product_date")]
        public string ProductDate { get; set; }

        /// <summary>
        /// 出库单状态,(NEW-未开始处理, ACCEPT-仓库接单 , PARTDELIVERED-部分发货完成, DELIVERED-发货完成, EXCEPTION-异常, CANCELED-取消, CLOSED-关闭, REJECT-拒单, CANCELEDFAIL-取消失败) , (只传英文编码)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
