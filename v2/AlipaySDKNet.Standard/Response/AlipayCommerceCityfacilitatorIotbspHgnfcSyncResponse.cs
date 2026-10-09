using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotbspHgnfcSyncResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorIotbspHgnfcSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回结果信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 二级错误码
        /// </summary>
        [XmlElement("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [XmlElement("ret_message")]
        public string RetMessage { get; set; }

        /// <summary>
        /// 二级错误信息
        /// </summary>
        [XmlElement("ret_message_sub")]
        public string RetMessageSub { get; set; }
    }
}
