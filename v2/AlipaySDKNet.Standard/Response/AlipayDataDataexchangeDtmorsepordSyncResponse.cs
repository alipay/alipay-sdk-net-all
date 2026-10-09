using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeDtmorsepordSyncResponse.
    /// </summary>
    public class AlipayDataDataexchangeDtmorsepordSyncResponse : AopResponse
    {
        /// <summary>
        /// 交易流水号，一次交易的唯一标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 结果扩展字段，用于补充出参内容
        /// </summary>
        [XmlElement("result_extent")]
        public string ResultExtent { get; set; }

        /// <summary>
        /// 操作结果信息，用于标识操作是否成功。true：表示成功，false：表示失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
