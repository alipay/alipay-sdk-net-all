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
        /// 用户是否开通花呗联名卡，true：表示当前用户已开通花呗联名卡，返回相关额度信息，false：表示用户未开通花呗联名卡，不返回相关额度信息。
        /// </summary>
        [XmlElement("opened")]
        public bool Opened { get; set; }

        /// <summary>
        /// 还款日，08-每月8号，10-每月10号。
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 总额度，单位：元，精确到小数点后2位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
