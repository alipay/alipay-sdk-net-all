using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSettleInInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSettleInInfo : AopObject
    {
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
        /// 间连周期卡开通状态
        /// </summary>
        [XmlElement("indirect_period_card_status")]
        public string IndirectPeriodCardStatus { get; set; }

        /// <summary>
        /// 最新的申请单
        /// </summary>
        [XmlArray("last_apply_orders")]
        [XmlArrayItem("merchant_apply_info")]
        public List<MerchantApplyInfo> LastApplyOrders { get; set; }

        /// <summary>
        /// 经营类目
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 周期卡开通状态
        /// </summary>
        [XmlElement("period_card_status")]
        public string PeriodCardStatus { get; set; }

        /// <summary>
        /// 开通状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
