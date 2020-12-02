using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountApplyResponse.
    /// </summary>
    public class AlipayBossFncSubaccountAccountApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请子户结果
        /// </summary>
        [XmlElement("result_set")]
        public ApplySubAccountAndBindResultDTO ResultSet { get; set; }
    }
}
