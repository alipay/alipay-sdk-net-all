using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyStaffQueryResponse.
    /// </summary>
    public class AlipayCommercePropertyStaffQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("staff_v_o")]
        public List<StaffVO> List { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
