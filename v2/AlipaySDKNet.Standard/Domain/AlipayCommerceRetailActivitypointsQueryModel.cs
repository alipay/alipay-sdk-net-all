using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailActivitypointsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailActivitypointsQueryModel : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlArray("activity_id_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityIdList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
