using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanarQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeLoanarQueryModel : AopObject
    {
        /// <summary>
        /// 客户的角色编号
        /// </summary>
        [XmlElement("iproleid")]
        public string Iproleid { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("loanarno")]
        public string Loanarno { get; set; }

        /// <summary>
        /// 用于场景角色的查询，默认不填 扫码付业务填 1
        /// </summary>
        [XmlElement("roletype")]
        public string Roletype { get; set; }
    }
}
