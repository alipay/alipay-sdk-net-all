using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCardGenerateCreateResponse.
    /// </summary>
    public class AlipayFundCardGenerateCreateResponse : AopResponse
    {
        /// <summary>
        /// 接收制卡请求落地之后的返回的支付宝制卡单号
        /// </summary>
        [XmlElement("fund_card_generate_no")]
        public string FundCardGenerateNo { get; set; }
    }
}
