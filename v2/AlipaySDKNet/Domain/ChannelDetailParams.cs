using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelDetailParams Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelDetailParams : AopObject
    {
        /// <summary>
        /// 预付卡分组名称
        /// </summary>
        [XmlElement("card_group_name")]
        public string CardGroupName { get; set; }

        /// <summary>
        /// 风控咨询结果
        /// </summary>
        [XmlElement("credit_risk_info")]
        public string CreditRiskInfo { get; set; }

        /// <summary>
        /// 芝麻人群标签
        /// </summary>
        [XmlElement("marketing_flag")]
        public string MarketingFlag { get; set; }

        /// <summary>
        /// 芝麻拒绝原因
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 用户是否已签约
        /// </summary>
        [XmlElement("user_has_sign")]
        public string UserHasSign { get; set; }
    }
}
