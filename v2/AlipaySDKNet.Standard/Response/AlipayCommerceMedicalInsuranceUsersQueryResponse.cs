using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceUsersQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceUsersQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户信息(包含亲情账户)
        /// </summary>
        [XmlArray("insurance_user_models")]
        [XmlArrayItem("insurance_user_information")]
        public List<InsuranceUserInformation> InsuranceUserModels { get; set; }

        /// <summary>
        /// 是否签约
        /// </summary>
        [XmlElement("signed")]
        public bool Signed { get; set; }

        /// <summary>
        /// 授权查询凭证
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
