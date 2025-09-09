using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskUnitedpidsQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskUnitedpidsQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回该unitedId关联的pid列表
        /// </summary>
        [XmlArray("pid_list")]
        [XmlArrayItem("string")]
        public List<string> PidList { get; set; }
    }
}
