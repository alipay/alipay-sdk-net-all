using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerMtopsyncModifyResponse.
    /// </summary>
    public class AlipayOpenMiniInnerMtopsyncModifyResponse : AopResponse
    {
        /// <summary>
        /// 业务调用成功code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 业务调用成功msg
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 调用结果的文字描述
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }

        /// <summary>
        /// Business Failed
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
