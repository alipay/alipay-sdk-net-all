using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyBizData Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyBizData : AopObject
    {
        /// <summary>
        /// 渠道用户标识
        /// </summary>
        [XmlElement("channel_user_tag")]
        public string ChannelUserTag { get; set; }

        /// <summary>
        /// 保单结束日期
        /// </summary>
        [XmlElement("effect_end_date")]
        public string EffectEndDate { get; set; }

        /// <summary>
        /// 保单生效日期
        /// </summary>
        [XmlElement("effect_start_date")]
        public string EffectStartDate { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("entrance")]
        public string Entrance { get; set; }

        /// <summary>
        /// 承保状态:  1-已出单
        /// </summary>
        [XmlElement("insure_status")]
        public string InsureStatus { get; set; }

        /// <summary>
        /// 合作商机构ID:  从保单的 bizData 中获取
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 出单保费金额,单位:分
        /// </summary>
        [XmlElement("premium_amount")]
        public long PremiumAmount { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 1.0001
        /// </summary>
        [XmlElement("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 标准产品ID: 从保单信息中获取
        /// </summary>
        [XmlElement("sp_no")]
        public string SpNo { get; set; }
    }
}
