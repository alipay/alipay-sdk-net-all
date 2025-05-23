using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNfccardSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportNfccardSendModel : AopObject
    {
        /// <summary>
        /// 发卡方pid
        /// </summary>
        [XmlElement("card_issuer_pid")]
        public string CardIssuerPid { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡片状态。枚举值如下： *  FREEZE：冻结。 *  CANCEL：销卡。
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 发卡机构代码
        /// </summary>
        [XmlElement("issue_org_no")]
        public string IssueOrgNo { get; set; }

        /// <summary>
        /// 签约升级：签约代扣协议 解约降级：解约代扣协议
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 签约免密协议的时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 解约时间
        /// </summary>
        [XmlElement("unsign_time")]
        public string UnsignTime { get; set; }

        /// <summary>
        /// 免密签约协议号
        /// </summary>
        [XmlElement("withhold_agreement_no")]
        public string WithholdAgreementNo { get; set; }
    }
}
