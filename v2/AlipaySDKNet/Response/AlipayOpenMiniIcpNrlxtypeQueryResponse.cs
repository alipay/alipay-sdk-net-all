using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIcpNrlxtypeQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIcpNrlxtypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 前置审批项类型
        /// </summary>
        [XmlArray("nrlx_types")]
        [XmlArrayItem("icp_nrlx_type_list")]
        public List<IcpNrlxTypeList> NrlxTypes { get; set; }
    }
}
