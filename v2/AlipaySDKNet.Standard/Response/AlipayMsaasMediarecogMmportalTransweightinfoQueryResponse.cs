using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalTransweightinfoQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmportalTransweightinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("achieve")]
        public string Achieve { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 重力段信息文件
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
