using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniResourceUserdataQueryResponse.
    /// </summary>
    public class AlipayOpenMiniResourceUserdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 流量位用户数据列表
        /// </summary>
        [XmlArray("user_data_list")]
        [XmlArrayItem("resource_user_data_v_o")]
        public List<ResourceUserDataVO> UserDataList { get; set; }
    }
}
