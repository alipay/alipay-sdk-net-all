using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationProductApplyResponse.
    /// </summary>
    public class AlipayBusinessRelationProductApplyResponse : AopResponse
    {
        /// <summary>
        /// 业务流水编号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
