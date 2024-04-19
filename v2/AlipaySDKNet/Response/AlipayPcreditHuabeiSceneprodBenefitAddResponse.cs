using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitAddResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSceneprodBenefitAddResponse : AopResponse
    {
        /// <summary>
        /// 追加预算流水ID
        /// </summary>
        [XmlElement("append_id")]
        public string AppendId { get; set; }
    }
}
