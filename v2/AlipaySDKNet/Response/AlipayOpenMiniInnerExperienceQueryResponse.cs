using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerExperienceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerExperienceQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 体验二维码地址
        /// </summary>
        [XmlElement("exp_qr_code_url")]
        public string ExpQrCodeUrl { get; set; }

        /// <summary>
        /// 体验码schema
        /// </summary>
        [XmlElement("exp_schema_url")]
        public string ExpSchemaUrl { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 查询指定版本的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
