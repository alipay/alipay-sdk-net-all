using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalCvgooodsonlinelistSyncResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmportalCvgooodsonlinelistSyncResponse : AopResponse
    {
        /// <summary>
        /// 结果字段，可扩展
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 响应返回码
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 返回接口处理结果, 包含异常消息
        /// </summary>
        [XmlElement("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 执行结果是否成功
        /// </summary>
        [XmlElement("ret_success")]
        public bool RetSuccess { get; set; }
    }
}
