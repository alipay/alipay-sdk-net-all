using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTerminalEdgecloudSimcardNetflowmonitorSyncResponse.
    /// </summary>
    public class AlipayTerminalEdgecloudSimcardNetflowmonitorSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步文件所属日期。yyyymmdd或yyyymm
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 本次同步文件的序列号
        /// </summary>
        [XmlElement("biz_date_file_seq_id")]
        public long BizDateFileSeqId { get; set; }

        /// <summary>
        /// 同步结果id
        /// </summary>
        [XmlElement("record_detail_id")]
        public string RecordDetailId { get; set; }
    }
}
