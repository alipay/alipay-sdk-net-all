using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OpenOrderDetail : AopObject
    {
        /// <summary>
        /// 计费方式： CPM-按展示次数收费
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 订单结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 广告投放平台生成的订单ID
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 订单名称
        /// </summary>
        [XmlElement("order_name")]
        public string OrderName { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放订单对应的外部资源ID
        /// </summary>
        [XmlElement("order_outer_id")]
        public string OrderOuterId { get; set; }

        /// <summary>
        /// 订单状态: INIT-初始化； STOCK_FAIL-锁库存失败； STOCK_SUCCESS-锁库存成功； CANCEL-已取消； FINISHED-已完成； TO_BE_START-待开始； ENABLE-已生效
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 广告投放平台生成委托人ID
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 套餐ID
        /// </summary>
        [XmlElement("profile_id")]
        public long ProfileId { get; set; }

        /// <summary>
        /// 总保量值
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 售卖方式： GD-合约交易
        /// </summary>
        [XmlElement("sell_mode")]
        public string SellMode { get; set; }

        /// <summary>
        /// 订单开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 总价格，单位：分
        /// </summary>
        [XmlElement("total_budget")]
        public long TotalBudget { get; set; }

        /// <summary>
        /// 广告投放平台生成广告主/代理商ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
