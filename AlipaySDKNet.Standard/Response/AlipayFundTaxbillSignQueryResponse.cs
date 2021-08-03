using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTaxbillSignQueryResponse.
    /// </summary>
    public class AlipayFundTaxbillSignQueryResponse : AopResponse
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
        /// 签约信息列表
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("esign_result")]
        public List<EsignResult> ResultList { get; set; }
    }
}
