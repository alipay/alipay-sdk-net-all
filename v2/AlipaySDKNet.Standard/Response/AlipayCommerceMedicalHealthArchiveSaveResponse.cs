using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthArchiveSaveResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthArchiveSaveResponse : AopResponse
    {
        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("data")]
        public MedicalHealthArchiveOptDTO Data { get; set; }
    }
}
