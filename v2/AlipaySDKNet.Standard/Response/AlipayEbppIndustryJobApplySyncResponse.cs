using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobApplySyncResponse.
    /// </summary>
    public class AlipayEbppIndustryJobApplySyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧应聘信息唯一标识，正常情况下非空。
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
