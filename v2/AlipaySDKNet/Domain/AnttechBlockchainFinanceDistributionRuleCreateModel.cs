using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceDistributionRuleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceDistributionRuleCreateModel : AopObject
    {
        /// <summary>
        /// 收益分配产品码, 请咨询业务同学获取
        /// </summary>
        [XmlElement("distribution_pro_no")]
        public string DistributionProNo { get; set; }

        /// <summary>
        /// 请求流水, 流水不变重复请求幂等，相同流水的规则参数不能变更。
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 收益分配转入方信息，可传多个
        /// </summary>
        [XmlArray("trans_in_info")]
        [XmlArrayItem("income_distribution_trans_in_info")]
        public List<IncomeDistributionTransInInfo> TransInInfo { get; set; }

        /// <summary>
        /// 收益分配分出方账号，证件、账户、户名需一致
        /// </summary>
        [XmlElement("trans_out_account_no")]
        public string TransOutAccountNo { get; set; }

        /// <summary>
        /// 分出方账户类型 目前只支持 01-子户/子钱包
        /// </summary>
        [XmlElement("trans_out_account_type")]
        public string TransOutAccountType { get; set; }

        /// <summary>
        /// 分出方证件号，证件、账户、户名需一致
        /// </summary>
        [XmlElement("trans_out_cert_no")]
        public string TransOutCertNo { get; set; }

        /// <summary>
        /// 分出方证件类型： 01 - 统一社会信用代码 02 - 身份证
        /// </summary>
        [XmlElement("trans_out_cert_type")]
        public string TransOutCertType { get; set; }

        /// <summary>
        /// 收益分配分出方的名称，证件、账户、名称需一致
        /// </summary>
        [XmlElement("trans_out_name")]
        public string TransOutName { get; set; }
    }
}
