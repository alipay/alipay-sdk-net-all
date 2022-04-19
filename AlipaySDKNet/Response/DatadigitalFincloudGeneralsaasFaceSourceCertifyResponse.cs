using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceSourceCertifyResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceSourceCertifyResponse : AopResponse
    {
        /// <summary>
        /// 人脸认证单据号，调用后续OpenAPI（datadigital.fincloud.generalsaas.face.source.query ）时传入，用来查询结果
        /// </summary>
        [XmlElement("certify_no")]
        public string CertifyNo { get; set; }

        /// <summary>
        /// T：通过；F：不通过
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
