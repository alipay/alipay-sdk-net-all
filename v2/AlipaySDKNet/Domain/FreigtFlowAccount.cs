using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreigtFlowAccount Data Structure.
    /// </summary>
    [Serializable]
    public class FreigtFlowAccount : AopObject
    {
        /// <summary>
        /// 银行类型
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 银行名字
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// mode为网商银行时网商结算户账号, mode为浦发银行为对应的监管账户
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("parent_name")]
        public string ParentName { get; set; }
    }
}
