using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillApiSingleItem Data Structure.
    /// </summary>
    [Serializable]
    public class BillApiSingleItem : AopObject
    {
        /// <summary>
        /// 账单单号
        /// </summary>
        [XmlElement("biz_in_no")]
        public string BizInNo { get; set; }

        /// <summary>
        /// 账单状态的描述说明
        /// </summary>
        [XmlElement("biz_state_desc")]
        public string BizStateDesc { get; set; }

        /// <summary>
        /// 账单分类，是按照账单内部标准划分的分类信息
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 账单显示金额，单位元，包含“+”“-”符号代表资金实际是正向还是逆向
        /// </summary>
        [XmlElement("consume_fee")]
        public string ConsumeFee { get; set; }

        /// <summary>
        /// 账单标题
        /// </summary>
        [XmlElement("consume_title")]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 创单时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 对手方展示名
        /// </summary>
        [XmlElement("opposite_name")]
        public string OppositeName { get; set; }

        /// <summary>
        /// 表示账单计入统计的金额，单位元
        /// </summary>
        [XmlElement("stat_fee")]
        public string StatFee { get; set; }

        /// <summary>
        /// 账单是否计入收支 ("0", "计入收支统计"), ("1", "不计入收支统计"), ("2", "部分计入收支统计");
        /// </summary>
        [XmlElement("stat_type")]
        public string StatType { get; set; }
    }
}
