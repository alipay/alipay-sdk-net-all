using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BFActivityOpenApiResult Data Structure.
    /// </summary>
    [Serializable]
    public class BFActivityOpenApiResult : AopObject
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlArray("activity_infos")]
        [XmlArrayItem("b_f_activity_open_api_info")]
        public List<BFActivityOpenApiInfo> ActivityInfos { get; set; }
    }
}
