using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityRoomBatchcreateResponse.
    /// </summary>
    public class AlipayEbppCommunityRoomBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 失败数
        /// </summary>
        [XmlElement("fail_count")]
        public string FailCount { get; set; }

        /// <summary>
        /// 明细结果
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("room_batch_create_result")]
        public List<RoomBatchCreateResult> Results { get; set; }

        /// <summary>
        /// 成功数
        /// </summary>
        [XmlElement("success_count")]
        public string SuccessCount { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
