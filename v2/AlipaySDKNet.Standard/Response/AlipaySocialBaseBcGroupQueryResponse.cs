using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseBcGroupQueryResponse.
    /// </summary>
    public class AlipaySocialBaseBcGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝群详情
        /// </summary>
        [XmlElement("group_detail")]
        public GroupDetail GroupDetail { get; set; }
    }
}
