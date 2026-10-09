using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerMembersQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerMembersQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlArray("open_app_operator_vo")]
        [XmlArrayItem("open_app_operator_vo")]
        public List<OpenAppOperatorVo> OpenAppOperatorVo { get; set; }
    }
}
