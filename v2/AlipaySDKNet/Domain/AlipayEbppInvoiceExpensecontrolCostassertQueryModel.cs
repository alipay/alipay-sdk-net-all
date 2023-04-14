using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolCostassertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecontrolCostassertQueryModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id，和授权签约协议号共同使用。
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号，可通过签约消息获取。配合企业共同账户id使用，当填写企业共同账户id时，此字段必填。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 描述：支付宝交易号，根据支付宝交易号查询交易消耗资产明细； 条件必选：（out_source_id、alipay_bill_no有且只能传一个）；
        /// </summary>
        [XmlElement("alipay_bill_no")]
        public string AlipayBillNo { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 切换open_id后请使用此字段：员工ID 特殊说明：根据员工账号类型来决定为open_id、员工工号、员工企业码ID或者员工手机号
        /// </summary>
        [XmlElement("employee_open_id")]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 描述：外部唯一交易ID，同外部消费同步入参out_source_id，根据外部交易号查询交易消耗资产明细； 条件必选：（out_source_id、alipay_bill_no有且只能传一个）；
        /// </summary>
        [XmlElement("out_source_id")]
        public string OutSourceId { get; set; }

        /// <summary>
        /// 调用平台标识，需同外部消费同步接口一致
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }
    }
}
