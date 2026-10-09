using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundItem Data Structure.
    /// </summary>
    [Serializable]
    public class FundItem : AopObject
    {
        /// <summary>
        /// 金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金明细创建时间
        /// </summary>
        [XmlElement("fund_create_time")]
        public string FundCreateTime { get; set; }

        /// <summary>
        /// 资金明细完成时间
        /// </summary>
        [XmlElement("fund_finish_time")]
        public string FundFinishTime { get; set; }

        /// <summary>
        /// 资金流向
        /// </summary>
        [XmlElement("fund_in_out")]
        public string FundInOut { get; set; }

        /// <summary>
        /// 资金明细更新时间
        /// </summary>
        [XmlElement("fund_modify_time")]
        public string FundModifyTime { get; set; }

        /// <summary>
        /// 资金工具名（中文）
        /// </summary>
        [XmlElement("fund_tool_type_name")]
        public string FundToolTypeName { get; set; }

        /// <summary>
        /// 业务创建时间
        /// </summary>
        [XmlElement("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 本方卡号
        /// </summary>
        [XmlElement("owner_card_no")]
        public string OwnerCardNo { get; set; }

        /// <summary>
        /// 是否为优惠资金工具
        /// </summary>
        [XmlElement("promo_fund_tool")]
        public bool PromoFundTool { get; set; }
    }
}
