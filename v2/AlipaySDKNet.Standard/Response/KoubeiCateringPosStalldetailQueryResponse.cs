using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosStalldetailQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStalldetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 档口模型
        /// </summary>
        [XmlElement("stall_entity")]
        public StallEntity StallEntity { get; set; }
    }
}
