using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryBillNettingRefundResponse.
    /// </summary>
    public class AlipayEbppIndustryBillNettingRefundResponse : AopResponse
    {
        /// <summary>
        /// 回传支付宝流水号。
        /// </summary>
        [XmlElement("alipay_bill_no")]
        public string AlipayBillNo { get; set; }

        /// <summary>
        /// 扩展字段，一系列键值对属性列表，示例只是个形式，具体的Key-Value需要根据具体业务另行约定。  无特别约定时，此字段不必传。
        /// </summary>
        [XmlArray("industry_extend_field_list")]
        [XmlArrayItem("industry_extend_field")]
        public List<IndustryExtendField> IndustryExtendFieldList { get; set; }
    }
}
