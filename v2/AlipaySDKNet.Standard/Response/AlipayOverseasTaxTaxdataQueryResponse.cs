using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxTaxdataQueryResponse.
    /// </summary>
    public class AlipayOverseasTaxTaxdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 最终退税金额，单位为元
        /// </summary>
        [XmlElement("final_refund_amount")]
        public string FinalRefundAmount { get; set; }

        /// <summary>
        /// 实际退税金额，当前仅支持CNY
        /// </summary>
        [XmlElement("final_refund_currency")]
        public string FinalRefundCurrency { get; set; }

        /// <summary>
        /// 用户全名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 外部商户单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退税机构id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// The actual payment time. 仅放款完成时存在，格式为yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 手机号场景时回传（当前无此场景，返回null）
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 退税单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 退税单号支付宝流水号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("user_id_open_id")]
        public string UserIdOpenId { get; set; }

        /// <summary>
        /// 用户登录id
        /// </summary>
        [XmlElement("user_login_id")]
        public string UserLoginId { get; set; }
    }
}
