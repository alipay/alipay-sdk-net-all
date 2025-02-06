using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySalaryFundflowApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySalaryFundflowApplyModel : AopObject
    {
        /// <summary>
        /// 子户账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 网商商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 对接收付通加签的xml，通过base64编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 回单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
