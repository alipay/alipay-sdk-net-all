using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalconsumeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalconsumeQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果数据列表，当无数据时，查询数据为空
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("principal_consume_detail")]
        public List<PrincipalConsumeDetail> DataList { get; set; }

        /// <summary>
        /// 分页查询的记录总条数，单位：条
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
