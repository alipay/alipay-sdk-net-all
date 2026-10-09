using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanschemeFullQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanschemeFullQueryResponse : AopResponse
    {
        /// <summary>
        /// 贷款支用时涉及的合约列表
        /// </summary>
        [XmlArray("contract_list")]
        [XmlArrayItem("contract")]
        public List<Contract> ContractList { get; set; }

        /// <summary>
        /// 对于返回的贷款方案、合约列表、收款信息等数字签名，防篡改，并确保用户看到的和系统后端处理的保持一致
        /// </summary>
        [XmlElement("data_sign")]
        public string DataSign { get; set; }

        /// <summary>
        /// 贷款方案，包含可贷额度、利率、期限、还款方式等贷款要素，在客户签署贷款协议时，展示这些信息给客户
        /// </summary>
        [XmlElement("loan_scheme")]
        public LoanScheme LoanScheme { get; set; }

        /// <summary>
        /// 还款账户
        /// </summary>
        [XmlElement("repay_account")]
        public MyBkAccountVO RepayAccount { get; set; }

        /// <summary>
        /// 收款账号信息
        /// </summary>
        [XmlElement("trans_in_account")]
        public MyBkAccountVO TransInAccount { get; set; }
    }
}
