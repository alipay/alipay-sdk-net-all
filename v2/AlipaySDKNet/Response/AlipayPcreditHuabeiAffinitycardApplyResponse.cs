using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAffinitycardApplyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAffinitycardApplyResponse : AopResponse
    {
        /// <summary>
        /// 可用额度，单位：元，精确到小数点后2位
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

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
        /// 花呗联名卡产品账户，后续可以基于该参数查询和关闭联名卡
        /// </summary>
        [XmlElement("user_prod_account_no")]
        public string UserProdAccountNo { get; set; }
    }
}
