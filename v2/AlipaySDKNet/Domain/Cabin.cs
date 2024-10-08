using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Cabin Data Structure.
    /// </summary>
    [Serializable]
    public class Cabin : AopObject
    {
        /// <summary>
        /// 减免后成人价，精确到元 若是中转航班，给出打包价格
        /// </summary>
        [XmlElement("adult_discount_price")]
        public string AdultDiscountPrice { get; set; }

        /// <summary>
        /// 成人价格，精确到元 若是中转航班，给出打包价格
        /// </summary>
        [XmlElement("adult_price")]
        public string AdultPrice { get; set; }

        /// <summary>
        /// 仓等标识 Y-经济舱，C-公务舱，F-头等舱 各个航司为了细分自己的仓等，比如经济舱下面，靠窗的价格高些，中间的价格低些，又可能区分I、J、等
        /// </summary>
        [XmlElement("cabin_code")]
        public string CabinCode { get; set; }

        /// <summary>
        /// 当前仓等相对于基础仓等的折扣，如果是经济舱，相对标准仓等价格为3.1折，则会展示经济舱3.1折
        /// </summary>
        [XmlElement("cabin_discount")]
        public string CabinDiscount { get; set; }

        /// <summary>
        /// 仓等名称描述
        /// </summary>
        [XmlElement("cabin_name")]
        public string CabinName { get; set; }

        /// <summary>
        /// 儿童价格，精确到元，仅作展示
        /// </summary>
        [XmlElement("child_price")]
        public string ChildPrice { get; set; }

        /// <summary>
        /// 优惠列表
        /// </summary>
        [XmlArray("discount_list")]
        [XmlArrayItem("discount")]
        public List<Discount> DiscountList { get; set; }

        /// <summary>
        /// 优惠券标签
        /// </summary>
        [XmlElement("discount_tag")]
        public string DiscountTag { get; set; }

        /// <summary>
        /// 燃油费用，精确到：元
        /// </summary>
        [XmlElement("fuel_cost")]
        public string FuelCost { get; set; }

        /// <summary>
        /// 婴儿价格，精确到元，仅作展示
        /// </summary>
        [XmlElement("infant_price")]
        public string InfantPrice { get; set; }

        /// <summary>
        /// 基建费用，精确到元
        /// </summary>
        [XmlElement("infrastructure_cost")]
        public string InfrastructureCost { get; set; }

        /// <summary>
        /// 航班详情跳转链接
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 托运政策描述
        /// </summary>
        [XmlArray("luggage_policies")]
        [XmlArrayItem("luggage_policy")]
        public List<LuggagePolicy> LuggagePolicies { get; set; }

        /// <summary>
        /// 餐食描述
        /// </summary>
        [XmlElement("meal")]
        public string Meal { get; set; }

        /// <summary>
        /// 改签政策
        /// </summary>
        [XmlArray("rebook_policies")]
        [XmlArrayItem("policy")]
        public List<Policy> RebookPolicies { get; set; }

        /// <summary>
        /// 退票政策
        /// </summary>
        [XmlArray("refund_policies")]
        [XmlArrayItem("policy")]
        public List<Policy> RefundPolicies { get; set; }

        /// <summary>
        /// 报销政策
        /// </summary>
        [XmlArray("reimbursement_policies")]
        [XmlArrayItem("reimbursement_policy")]
        public List<ReimbursementPolicy> ReimbursementPolicies { get; set; }

        /// <summary>
        /// 售卖限制的列表
        /// </summary>
        [XmlArray("sale_controls")]
        [XmlArrayItem("sale_control")]
        public List<SaleControl> SaleControls { get; set; }

        /// <summary>
        /// 余票数量，不明确可为空
        /// </summary>
        [XmlElement("ticket_count")]
        public string TicketCount { get; set; }
    }
}
