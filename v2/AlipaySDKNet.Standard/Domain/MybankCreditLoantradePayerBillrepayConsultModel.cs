using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradePayerBillrepayConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradePayerBillrepayConsultModel : AopObject
    {
        /// <summary>
        /// 指定账单号，为空查询所有账单
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务场景，由网商端指定
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 子场景，可空
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 用户信息，必填
        /// </summary>
        [XmlElement("user_info")]
        public CreditPayUserVO UserInfo { get; set; }
    }
}
