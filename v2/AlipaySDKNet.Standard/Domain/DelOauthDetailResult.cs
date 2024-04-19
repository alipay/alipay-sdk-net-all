using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DelOauthDetailResult Data Structure.
    /// </summary>
    [Serializable]
    public class DelOauthDetailResult : AopObject
    {
        /// <summary>
        /// 解除授权记录列表
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("del_oauth_detail")]
        public List<DelOauthDetail> Details { get; set; }
    }
}
