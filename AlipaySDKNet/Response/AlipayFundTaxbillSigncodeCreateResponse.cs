using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTaxbillSigncodeCreateResponse.
    /// </summary>
    public class AlipayFundTaxbillSigncodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 签约吱口令，请求成功响应时存在
        /// </summary>
        [XmlElement("sign_code")]
        public string SignCode { get; set; }
    }
}
