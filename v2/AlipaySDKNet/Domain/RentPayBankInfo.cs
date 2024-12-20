using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayBankInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayBankInfo : AopObject
    {
        /// <summary>
        /// 收款账户开户人名称
        /// </summary>
        [XmlElement("rent_acct_name")]
        public string RentAcctName { get; set; }

        /// <summary>
        /// 公积金中心对租赁机构收款银行分配的银行编码
        /// </summary>
        [XmlElement("rent_bank_code")]
        public string RentBankCode { get; set; }

        /// <summary>
        /// 开户银行全称
        /// </summary>
        [XmlElement("rent_bank_name")]
        public string RentBankName { get; set; }

        /// <summary>
        /// 收款银行账号号码
        /// </summary>
        [XmlElement("rent_card_num")]
        public string RentCardNum { get; set; }
    }
}
