using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBrandsolutionEnrollmerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBrandsolutionEnrollmerchantQueryModel : AopObject
    {
        /// <summary>
        /// 活动唯一标识
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// pid的列表，只查询需要的pid的报名列表
        /// </summary>
        [XmlArray("pids")]
        [XmlArrayItem("string")]
        public List<string> Pids { get; set; }
    }
}
