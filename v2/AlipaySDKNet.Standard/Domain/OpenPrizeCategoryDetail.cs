using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenPrizeCategoryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OpenPrizeCategoryDetail : AopObject
    {
        /// <summary>
        /// 剩余可领取次数
        /// </summary>
        [XmlElement("available_receive")]
        public long AvailableReceive { get; set; }

        /// <summary>
        /// 类目剩余可领取次数
        /// </summary>
        [XmlElement("category_available_receive")]
        public long CategoryAvailableReceive { get; set; }

        /// <summary>
        /// 当前群组已领取次数
        /// </summary>
        [XmlElement("current_group_receive")]
        public long CurrentGroupReceive { get; set; }

        /// <summary>
        /// 当前类目已领取次数
        /// </summary>
        [XmlElement("current_receive")]
        public long CurrentReceive { get; set; }

        /// <summary>
        /// 券满减门槛-满金额，单位：元
        /// </summary>
        [XmlElement("from_amount")]
        public string FromAmount { get; set; }

        /// <summary>
        /// 群组剩余可领取次数
        /// </summary>
        [XmlElement("group_available_receive")]
        public long GroupAvailableReceive { get; set; }

        /// <summary>
        /// 当前群组领取次数上限
        /// </summary>
        [XmlElement("group_limit")]
        public long GroupLimit { get; set; }

        /// <summary>
        /// 群组剩余实际可领取次数（排除掉没有预算的奖品个数）
        /// </summary>
        [XmlElement("group_real_available_receive")]
        public long GroupRealAvailableReceive { get; set; }

        /// <summary>
        /// 不同分组间展示排序顺序,值小的展示在前
        /// </summary>
        [XmlElement("group_view_order")]
        public long GroupViewOrder { get; set; }

        /// <summary>
        /// 同一分组内部展示排序顺序,值小的展示在前
        /// </summary>
        [XmlElement("inner_view_order")]
        public long InnerViewOrder { get; set; }

        /// <summary>
        /// 奖品ID
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 是否已达类目领取上限
        /// </summary>
        [XmlElement("reach_category_limit")]
        public bool ReachCategoryLimit { get; set; }

        /// <summary>
        /// 是否已达到群组领取上限
        /// </summary>
        [XmlElement("reach_group_limit")]
        public bool ReachGroupLimit { get; set; }

        /// <summary>
        /// 是否已到领取上限（类目 || 群组）
        /// </summary>
        [XmlElement("reach_upper_limit")]
        public bool ReachUpperLimit { get; set; }

        /// <summary>
        /// 类目领取次数上限
        /// </summary>
        [XmlElement("receive_limit")]
        public long ReceiveLimit { get; set; }

        /// <summary>
        /// 是否剩余预算
        /// </summary>
        [XmlElement("remain_budget")]
        public bool RemainBudget { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券满减门槛-减金额（仅适用于满减券），单位：元
        /// </summary>
        [XmlElement("to_amount")]
        public string ToAmount { get; set; }

        /// <summary>
        /// 券所属行业/类目
        /// </summary>
        [XmlElement("voucher_biz_code")]
        public string VoucherBizCode { get; set; }
    }
}
