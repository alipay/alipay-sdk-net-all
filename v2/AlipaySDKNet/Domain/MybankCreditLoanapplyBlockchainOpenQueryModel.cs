using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyBlockchainOpenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyBlockchainOpenQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型,BLOCKCHAIN_QUERY_EVENT,机构数据链上查询,SDK枚举获取 业务类型
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 业务字段，暂时不需要，后续考虑到不同机构的差异性，预留。
        /// </summary>
        [XmlElement("data_object")]
        public string DataObject { get; set; }
    }
}
