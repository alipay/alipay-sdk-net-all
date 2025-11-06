using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideorecordQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcVideorecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 观看录播提示信息
        /// </summary>
        [XmlElement("record_watch_notice")]
        public string RecordWatchNotice { get; set; }

        /// <summary>
        /// 录播信息列表
        /// </summary>
        [XmlArray("records_info")]
        [XmlArrayItem("record_info")]
        public List<RecordInfo> RecordsInfo { get; set; }
    }
}
