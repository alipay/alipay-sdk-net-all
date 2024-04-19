using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IncomeDistributionOrderTransInDetail Data Structure.
    /// </summary>
    [Serializable]
    public class IncomeDistributionOrderTransInDetail : AopObject
    {
        /// <summary>
        /// 收款金额,单元元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("trans_in_account_no")]
        public string TransInAccountNo { get; set; }

        /// <summary>
        /// 收款方账户类型 01-数币子钱包 03-外部银行账户 04-标准数币钱包
        /// </summary>
        [XmlElement("trans_in_account_type")]
        public string TransInAccountType { get; set; }

        /// <summary>
        /// 收款方名称
        /// </summary>
        [XmlElement("trans_in_name")]
        public string TransInName { get; set; }
    }
}
