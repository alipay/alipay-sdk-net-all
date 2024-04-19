using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTemplateVerifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvTemplateVerifyResponse : AopResponse
    {
        /// <summary>
        /// 模板识别精确度(单位 %)
        /// </summary>
        [XmlElement("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 模板识别精确度是否通过
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
