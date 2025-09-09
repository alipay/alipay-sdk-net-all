using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenPoboQueryResponse.
    /// </summary>
    public class AlipayOverseasOpenPoboQueryResponse : AopResponse
    {
        /// <summary>
        /// auth 记录列表
        /// </summary>
        [XmlArray("auth_records")]
        [XmlArrayItem("indr_pobo_auth_record_d_t_o")]
        public List<IndrPoboAuthRecordDTO> AuthRecords { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
