using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalFamilyinfoAuthQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalFamilyinfoAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 已授权家人信息列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("authorized_family_info")]
        public List<AuthorizedFamilyInfo> Data { get; set; }
    }
}
