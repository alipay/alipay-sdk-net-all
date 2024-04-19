using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopmemberAddResponse.
    /// </summary>
    public class AlipayBusinessRelationShopmemberAddResponse : AopResponse
    {
        /// <summary>
        /// 商业关系物理门店资产成员编号
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }
    }
}
