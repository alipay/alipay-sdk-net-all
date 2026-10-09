using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundIndustryPurchaseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundIndustryPurchaseModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，调用签约接口成功时返回。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 基金申购时间，以此时间为准报送清算，必传，且不可跨日。
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 已废弃，勿用。请使用open_id字段
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 订单超时时间，格式： 3s: 3 seconds 3m: 3 minutes 3h: 3 hours 3d: 3 days 订单超时后不可操作基金撤销，如果不传默认超时时间365天
        /// </summary>
        [XmlElement("order_timeout")]
        public string OrderTimeout { get; set; }

        /// <summary>
        /// 平台外部请求号，用作幂等号，需要保证在该平台（pid）下唯一
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
