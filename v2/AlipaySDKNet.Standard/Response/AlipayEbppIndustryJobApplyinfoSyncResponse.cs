using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobApplyinfoSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryJobApplyinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝就业应聘id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
