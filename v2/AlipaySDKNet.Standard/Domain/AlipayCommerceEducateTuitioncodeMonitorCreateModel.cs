using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeMonitorCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodeMonitorCreateModel : AopObject
    {
        /// <summary>
        /// 银行类型(浙江网商：ZJWS)
        /// </summary>
        [XmlElement("bank_type")]
        public string BankType { get; set; }

        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [XmlElement("login_account")]
        public string LoginAccount { get; set; }

        /// <summary>
        /// ISV的申请监管户编号
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 商户在网商的西进户
        /// </summary>
        [XmlElement("parent_no")]
        public string ParentNo { get; set; }
    }
}
