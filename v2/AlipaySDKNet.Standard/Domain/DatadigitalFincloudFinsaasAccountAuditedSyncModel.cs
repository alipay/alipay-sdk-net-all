using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasAccountAuditedSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasAccountAuditedSyncModel : AopObject
    {
        /// <summary>
        /// 用户有几张卡。如果是新申请卡（之前没有卡），那么值为1
        /// </summary>
        [XmlElement("bank_cards_number")]
        public long BankCardsNumber { get; set; }

        /// <summary>
        /// 标识用户活动数据的唯一id
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 批核通过时间
        /// </summary>
        [XmlElement("gmt_audited")]
        public string GmtAudited { get; set; }
    }
}
