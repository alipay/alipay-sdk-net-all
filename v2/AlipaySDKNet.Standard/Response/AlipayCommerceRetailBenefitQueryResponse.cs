using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitQueryResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("activity_id_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityIdList { get; set; }

        /// <summary>
        /// 活动数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
