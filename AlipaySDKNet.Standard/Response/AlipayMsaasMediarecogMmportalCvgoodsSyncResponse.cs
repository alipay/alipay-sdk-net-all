using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalCvgoodsSyncResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmportalCvgoodsSyncResponse : AopResponse
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
        /// 上新结果描述
        /// </summary>
        [XmlElement("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 上新成功与否判断
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
