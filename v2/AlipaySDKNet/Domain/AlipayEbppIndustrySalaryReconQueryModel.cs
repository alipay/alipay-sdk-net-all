using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySalaryReconQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySalaryReconQueryModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 交易日期，格式为yyyyMMdd 交易最终成功或失败的日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 扩展信息，Map的json序列化后Base64(暂无需填写)
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 代发商户的商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部交易号。由合作方系统生成，只能包含字母、数字、下划线；需保证合作方系统不重复。
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
        /// 下载账单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
