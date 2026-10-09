using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntProdpaasProductDeliveryCompleteCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasProductDeliveryCompleteCallbackModel : AopObject
    {
        /// <summary>
        /// 是否异常反馈，如果该字段为 Y , 则其余必填字段可不填.如果供应商由于客关原因，认为该任务无法正常完成, 则可以通过完成反馈接口异常完结。
        /// </summary>
        [XmlElement("abnormal_feedback")]
        public string AbnormalFeedback { get; set; }

        /// <summary>
        /// 异常完结反馈原因
        /// </summary>
        [XmlElement("abnormal_reason")]
        public string AbnormalReason { get; set; }

        /// <summary>
        /// 实发商品数量
        /// </summary>
        [XmlElement("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// 批次编号，批次号和批次列表不可同时为空。
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次列表信息，批次号和批次列表不可同时为空。
        /// </summary>
        [XmlArray("batchs")]
        [XmlArrayItem("supplier_delivery_batch")]
        public List<SupplierDeliveryBatch> Batchs { get; set; }

        /// <summary>
        /// 发货单号
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
        [XmlElement("extend_pros")]
        public SupplierItemAttrField ExtendPros { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlArray("logistics_info")]
        [XmlArrayItem("supplier_logistics_info")]
        public List<SupplierLogisticsInfo> LogisticsInfo { get; set; }

        /// <summary>
        /// 计划发货数量
        /// </summary>
        [XmlElement("plan_amount")]
        public long PlanAmount { get; set; }

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
        /// 仓库编号
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
