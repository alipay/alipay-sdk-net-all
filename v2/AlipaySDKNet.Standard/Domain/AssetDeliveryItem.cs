using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetDeliveryItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryItem : AopObject
    {
        /// <summary>
        /// SEND - 发货指令(执行向目的地进行发货动作) , RECEIVE - 收货指令(执行从来源地进行收货动作)
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 配送数量
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 订单申请日期, 格式:  yyyy-MM-dd HH：mm:ss
        /// </summary>
        [XmlElement("apply_order_date")]
        public string ApplyOrderDate { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 配送订单唯一Id
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 支付宝内部的配送流水号, 可供物料商和物流商用于对账.
        /// </summary>
        [XmlElement("assign_out_order_id")]
        public string AssignOutOrderId { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("biz_line")]
        public string BizLine { get; set; }

        /// <summary>
        /// 参数描述对应的正向业务场景，包括默认正向以及维保对应发货单
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 物料渠道标识
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 用于线下供应商区分业务流程，目前采用双方约定方
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 合单批次号
        /// </summary>
        [XmlElement("combination_batch_no")]
        public string CombinationBatchNo { get; set; }

        /// <summary>
        /// 合单单据数量
        /// </summary>
        [XmlElement("combination_count")]
        public long CombinationCount { get; set; }

        /// <summary>
        /// 合单单据列表
        /// </summary>
        [XmlArray("combination_orders")]
        [XmlArrayItem("string")]
        public List<string> CombinationOrders { get; set; }

        /// <summary>
        /// 提供给物流商清关所用信息
        /// </summary>
        [XmlElement("custom_clearance")]
        public CCInfo CustomClearance { get; set; }

        /// <summary>
        /// 配送指令单据明细ID
        /// </summary>
        [XmlElement("delivery_assign_order_item_id")]
        public string DeliveryAssignOrderItemId { get; set; }

        /// <summary>
        /// 送货单号
        /// </summary>
        [XmlElement("delivery_process_no")]
        public string DeliveryProcessNo { get; set; }

        /// <summary>
        /// 调拨指令承运方pid
        /// </summary>
        [XmlElement("delivery_process_supplier_id")]
        public string DeliveryProcessSupplierId { get; set; }

        /// <summary>
        /// 调拨承运方供应商名称
        /// </summary>
        [XmlElement("delivery_process_supplier_name")]
        public string DeliveryProcessSupplierName { get; set; }

        /// <summary>
        /// 物流商全称
        /// </summary>
        [XmlElement("delivery_supplier_full_name")]
        public string DeliverySupplierFullName { get; set; }

        /// <summary>
        /// 物流商ID
        /// </summary>
        [XmlElement("delivery_supplier_id")]
        public string DeliverySupplierId { get; set; }

        /// <summary>
        /// 物流商名称
        /// </summary>
        [XmlElement("delivery_supplier_name")]
        public string DeliverySupplierName { get; set; }

        /// <summary>
        /// 配送类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 发送地址
        /// </summary>
        [XmlElement("from_address")]
        public AssetDeliveryAddress FromAddress { get; set; }

        /// <summary>
        /// 配送指令生成日期, 格式:yyyy-MM-dd HH：mm:ss
        /// </summary>
        [XmlElement("gmt_assign")]
        public string GmtAssign { get; set; }

        /// <summary>
        /// Y 需要合单 N 不需要合单
        /// </summary>
        [XmlElement("is_combination_order")]
        public string IsCombinationOrder { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物流单信息
        /// </summary>
        [XmlElement("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否走产包一体, IS_PRODUCE_ASSEBLE, 如果是Y，则是
        /// </summary>
        [XmlElement("operate_info")]
        public string OperateInfo { get; set; }

        /// <summary>
        /// 是否有选配物料
        /// </summary>
        [XmlElement("optional_item_flag")]
        public string OptionalItemFlag { get; set; }

        /// <summary>
        /// 是否有选配物料标识
        /// </summary>
        [XmlArray("optional_item_infos")]
        [XmlArrayItem("optional_item_info")]
        public List<OptionalItemInfo> OptionalItemInfos { get; set; }

        /// <summary>
        /// 公司主体代码
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 公司主体名
        /// </summary>
        [XmlElement("ou_name")]
        public string OuName { get; set; }

        /// <summary>
        /// 外部业务单号，例如淘宝订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 1. 如果该物料是套组的子物料, 那么该值为套组物料id;  2, 其他情况和物料id(即, item_id)一致或者为空.
        /// </summary>
        [XmlElement("parent_item_id")]
        public string ParentItemId { get; set; }

        /// <summary>
        /// 面单信息
        /// </summary>
        [XmlElement("print_data")]
        public string PrintData { get; set; }

        /// <summary>
        /// 指令排产优先级，100 正常优先级  200 高优先级
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// 生产调拨对应的生产指令.
        /// </summary>
        [XmlElement("produce_order_item_id")]
        public string ProduceOrderItemId { get; set; }

        /// <summary>
        /// TO_CUSTOMER : 到客户的配送指令; INTERIM : 中转配送指令. 可选值详见openApi文档.
        /// </summary>
        [XmlElement("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// 对应供应商pid
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 对应供应商名称
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 接收地址(目的地址)
        /// </summary>
        [XmlElement("to_address")]
        public AssetDeliveryAddress ToAddress { get; set; }

        /// <summary>
        /// 加急单的标识，Y是加急单 N非加急单
        /// </summary>
        [XmlElement("urgent_order_flag")]
        public string UrgentOrderFlag { get; set; }

        /// <summary>
        /// 动作
        /// </summary>
        [XmlElement("work_process")]
        public string WorkProcess { get; set; }
    }
}
