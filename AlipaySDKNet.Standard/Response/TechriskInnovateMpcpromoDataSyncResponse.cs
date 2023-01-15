using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoDataSyncResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 商品数据列表
        /// </summary>
        [XmlElement("data_list")]
        public MpcpromoGoodsList DataList { get; set; }

        /// <summary>
        /// 请求链路标识，用于排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
