using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetReverseItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseItem : AopObject
    {
        /// <summary>
        /// 行为类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 逆向申请单ID
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 逆向申请单明细ID
        /// </summary>
        [XmlElement("apply_order_item_id")]
        public string ApplyOrderItemId { get; set; }

        /// <summary>
        /// returning goods info
        /// </summary>
        [XmlElement("asset_reverse_goods_items")]
        public AssetReverseGoodsItem AssetReverseGoodsItems { get; set; }

        /// <summary>
        /// 取消订单或退货唯一Id
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("biz_line")]
        public string BizLine { get; set; }

        /// <summary>
        /// 业务渠道
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 出货地址
        /// </summary>
        [XmlElement("from_address")]
        public AssetDeliveryAddress FromAddress { get; set; }

        /// <summary>
        /// 物料ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }

        /// <summary>
        /// 原申请单ID
        /// </summary>
        [XmlElement("original_apply_order_id")]
        public string OriginalApplyOrderId { get; set; }

        /// <summary>
        /// 原配送单明细ID
        /// </summary>
        [XmlElement("original_apply_order_item_id")]
        public string OriginalApplyOrderItemId { get; set; }

        /// <summary>
        /// 原配送单id
        /// </summary>
        [XmlElement("original_deliver_order_id")]
        public string OriginalDeliverOrderId { get; set; }

        /// <summary>
        /// 原配送明细id
        /// </summary>
        [XmlElement("original_deliver_order_item_id")]
        public string OriginalDeliverOrderItemId { get; set; }

        /// <summary>
        /// 原配送单物料号
        /// </summary>
        [XmlElement("original_delivery_assign_item_id")]
        public string OriginalDeliveryAssignItemId { get; set; }

        /// <summary>
        /// 用于标识该指令为中转或者配送至客户. 其他类型的配送指令为空值
        /// </summary>
        [XmlElement("original_record_type")]
        public string OriginalRecordType { get; set; }

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
        /// 逆向申请单ID
        /// </summary>
        [XmlElement("reverse_apply_order_id")]
        public string ReverseApplyOrderId { get; set; }

        /// <summary>
        /// 逆向申请单明细ID
        /// </summary>
        [XmlElement("reverse_apply_order_item_id")]
        public string ReverseApplyOrderItemId { get; set; }

        /// <summary>
        /// 逆向业务场景，用于区分不同场景： DEFAULT_SCENE-兼容原淘宝天猫场景 USER_WITHOUT_GOODS_EXPRESS_RETURN用户未收到货-快递退回，供应商需进行拦截 USER_WITH_GOODS_SELF_MAIL_BACK-用户已收到货-用户直接寄回，供应商需等待商品回到仓库
        /// </summary>
        [XmlElement("reverse_biz_scene")]
        public string ReverseBizScene { get; set; }

        /// <summary>
        /// 逆向类型
        /// </summary>
        [XmlElement("reverse_type")]
        public string ReverseType { get; set; }

        /// <summary>
        /// 目标地址
        /// </summary>
        [XmlElement("to_address")]
        public AssetDeliveryAddress ToAddress { get; set; }
    }
}
