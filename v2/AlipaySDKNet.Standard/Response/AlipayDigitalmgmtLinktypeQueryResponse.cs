using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtLinktypeQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtLinktypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 环节类型信息列表
        /// </summary>
        [XmlElement("link_type_list_result")]
        public LinkTypeListResult LinkTypeListResult { get; set; }
    }
}
