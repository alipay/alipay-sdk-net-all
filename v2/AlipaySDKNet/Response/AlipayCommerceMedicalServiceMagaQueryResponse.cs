using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceMagaQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceMagaQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务投放数据实体
        /// </summary>
        [XmlElement("data")]
        public MedicalServiceMagaDTO Data { get; set; }
    }
}
