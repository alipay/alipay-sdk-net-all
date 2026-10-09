using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsTouchuvQueryResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsTouchuvQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("touch_uv_infos")]
        [XmlArrayItem("touch_uv_info")]
        public List<TouchUvInfo> TouchUvInfos { get; set; }
    }
}
