using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCardGenerateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCardGenerateQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，DEPOSIT_CERT：充值凭证
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 接收制卡请求落地之后的返回的支付宝制卡单号，条件必填二选一
        /// </summary>
        [XmlElement("fund_card_generate_no")]
        public string FundCardGenerateNo { get; set; }

        /// <summary>
        /// 外部单号，幂等用，条件必填二选一
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
