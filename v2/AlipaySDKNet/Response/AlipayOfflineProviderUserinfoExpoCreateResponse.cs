using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderUserinfoExpoCreateResponse.
    /// </summary>
    public class AlipayOfflineProviderUserinfoExpoCreateResponse : AopResponse
    {
        /// <summary>
        /// 入库成功的核验用户ID
        /// </summary>
        [XmlArray("vid_list")]
        [XmlArrayItem("string")]
        public List<string> VidList { get; set; }
    }
}
