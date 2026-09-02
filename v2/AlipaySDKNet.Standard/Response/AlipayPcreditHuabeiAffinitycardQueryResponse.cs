using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAffinitycardQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAffinitycardQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用额度，单位：元，精确到小数点后2位
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 用户联名卡关闭原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 用户联名卡关闭类型，用于区分主动关闭还是被动关闭
        /// </summary>
        [XmlElement("close_type")]
        public string CloseType { get; set; }

        /// <summary>
        /// 用户是否开通花呗联名卡，true：表示当前用户已开通花呗联名卡，返回相关额度信息，false：表示用户未开通花呗联名卡，不返回相关额度信息。
        /// </summary>
        [XmlElement("opened")]
        public bool Opened { get; set; }

        /// <summary>
        /// 还款日，08表示每月8号，10表示每月10号
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 总额度，单位：元，精确到小数点后2位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 如果入参中传入产品账户号或者用户已开通花呗联名卡，返回联名卡产品账户号
        /// </summary>
        [XmlElement("user_prod_account_no")]
        public string UserProdAccountNo { get; set; }
    }
}
