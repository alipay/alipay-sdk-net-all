using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateSalesgptOrderModifyResponse.
    /// </summary>
    public class TechriskInnovateSalesgptOrderModifyResponse : AopResponse
    {
        /// <summary>
        /// 提交描述错误码
        /// </summary>
        [XmlElement("order_submit_code")]
        public string OrderSubmitCode { get; set; }

        /// <summary>
        /// 提交描述
        /// </summary>
        [XmlElement("order_submit_msg")]
        public string OrderSubmitMsg { get; set; }

        /// <summary>
        /// 订单上报或更新结果
        /// </summary>
        [XmlElement("order_submit_result")]
        public bool OrderSubmitResult { get; set; }
    }
}
