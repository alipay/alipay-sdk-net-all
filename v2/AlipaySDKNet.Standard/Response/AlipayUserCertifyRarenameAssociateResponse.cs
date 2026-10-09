using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyRarenameAssociateResponse.
    /// </summary>
    public class AlipayUserCertifyRarenameAssociateResponse : AopResponse
    {
        /// <summary>
        /// rare_name_infos
        /// </summary>
        [XmlElement("rare_name_infos")]
        public RareNameInfo RareNameInfos { get; set; }
    }
}
