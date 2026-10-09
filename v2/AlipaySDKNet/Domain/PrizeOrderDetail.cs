using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeOrderDetail : AopObject
    {
        /// <summary>
        /// 预算类型
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动单据id
        /// </summary>
        [XmlElement("camp_order_id")]
        public string CampOrderId { get; set; }

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
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部奖品id
        /// </summary>
        [XmlElement("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 父发奖单据id，只有组合奖品类型时才可能出现
        /// </summary>
        [XmlElement("parent_order_id")]
        public string ParentOrderId { get; set; }

        /// <summary>
        /// 奖品金额单位分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品子类型
        /// </summary>
        [XmlElement("prize_sub_type")]
        public string PrizeSubType { get; set; }

        /// <summary>
        /// 奖品类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 发奖单据id
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 发奖状态
        /// </summary>
        [XmlElement("send_status")]
        public string SendStatus { get; set; }
    }
}
