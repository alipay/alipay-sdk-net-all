using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementQuotaModifyList Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementQuotaModifyList : AopObject
    {
        /// <summary>
        /// 授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 设置额度明细
        /// </summary>
        [XmlArray("quota_details")]
        [XmlArrayItem("modify_quota_details")]
        public List<ModifyQuotaDetails> QuotaDetails { get; set; }
    }
}
