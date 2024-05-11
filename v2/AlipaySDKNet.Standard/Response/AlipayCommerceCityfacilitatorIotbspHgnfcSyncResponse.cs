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
        /// result
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// retCode
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// ret_code_sub
        /// </summary>
        [XmlElement("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// retMessage
        /// </summary>
        [XmlElement("ret_message")]
        public string RetMessage { get; set; }

        /// <summary>
        /// retMessageSub
        /// </summary>
        [XmlElement("ret_message_sub")]
        public string RetMessageSub { get; set; }
    }
}
