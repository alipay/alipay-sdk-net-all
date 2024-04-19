using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenDataServiceQueryResponse.
    /// </summary>
    public class AlipayOpenDataServiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("group_records")]
        [XmlArrayItem("group_record")]
        public List<GroupRecord> GroupRecords { get; set; }

        /// <summary>
        /// 是否成功  true：成功  false:失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
