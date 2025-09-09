using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddOrderRequiredQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddOrderRequiredQueryResponse : AopResponse
    {
        /// <summary>
        /// 必填信息
        /// </summary>
        [XmlArray("require_info_list")]
        [XmlArrayItem("require_bean")]
        public List<RequireBean> RequireInfoList { get; set; }
    }
}
