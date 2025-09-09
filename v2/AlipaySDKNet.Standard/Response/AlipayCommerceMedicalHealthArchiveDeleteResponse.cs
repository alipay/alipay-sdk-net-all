using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthArchiveDeleteResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthArchiveDeleteResponse : AopResponse
    {
        /// <summary>
        /// 操作数据
        /// </summary>
        [XmlElement("data")]
        public MedicalHealthArchiveOptDTO Data { get; set; }
    }
}
