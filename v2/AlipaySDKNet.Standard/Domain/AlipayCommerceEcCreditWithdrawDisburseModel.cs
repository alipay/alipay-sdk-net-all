using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditWithdrawDisburseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditWithdrawDisburseModel : AopObject
    {
        /// <summary>
        /// 关联的取款申请明细列表
        /// </summary>
        [XmlArray("credit_withdraw_apply_info_list")]
        [XmlArrayItem("credit_withdraw_apply_info")]
        public List<CreditWithdrawApplyInfo> CreditWithdrawApplyInfoList { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 转账金额，单位元，精度分
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 资方转账唯一流水号
        /// </summary>
        [XmlElement("trans_serial_no")]
        public string TransSerialNo { get; set; }

        /// <summary>
        /// 到账时间
        /// </summary>
        [XmlElement("trans_time")]
        public string TransTime { get; set; }
    }
}
