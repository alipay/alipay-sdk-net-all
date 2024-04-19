using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportsrecordQueryResponse.
    /// </summary>
    public class AlipayUserSportsrecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// {"record_id":"dfasdjkfhasdjkhfdkas","record_date":"2023-08-28","sport_type":"run"}
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("sports_record_info")]
        public List<SportsRecordInfo> RecordList { get; set; }
    }
}
