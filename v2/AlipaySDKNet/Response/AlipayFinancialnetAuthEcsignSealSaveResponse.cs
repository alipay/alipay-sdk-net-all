using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSealSaveResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignSealSaveResponse : AopResponse
    {
        /// <summary>
        /// 印章ID，如果有则为唯一值，用于印章更新场景，在创建完和更新完均会返回该值。
        /// </summary>
        [XmlElement("seal_id")]
        public string SealId { get; set; }
    }
}
