using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchDetailsByInviterRes Data Structure.
    /// </summary>
    [Serializable]
    public class SearchDetailsByInviterRes : AopObject
    {
        /// <summary>
        /// 邀请单列表
        /// </summary>
        [XmlArray("res_items")]
        [XmlArrayItem("search_details_by_inviter_res_item")]
        public List<SearchDetailsByInviterResItem> ResItems { get; set; }
    }
}
