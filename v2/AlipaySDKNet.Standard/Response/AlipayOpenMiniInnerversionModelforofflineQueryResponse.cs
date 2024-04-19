using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionModelforofflineQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionModelforofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 线上版本包数据
        /// </summary>
        [XmlElement("model_json")]
        public string ModelJson { get; set; }

        /// <summary>
        /// 同步ID，同步失败时便于去线上追溯
        /// </summary>
        [XmlElement("sync_id")]
        public string SyncId { get; set; }
    }
}
