using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchSessionListQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchSessionListQueryResponse : AopResponse
    {
        /// <summary>
        /// 会话列表
        /// </summary>
        [XmlArray("session_list")]
        [XmlArrayItem("z_x_z_session_detail")]
        public List<ZXZSessionDetail> SessionList { get; set; }
    }
}
