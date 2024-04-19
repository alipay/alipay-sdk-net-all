using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgQueryAllListApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgQueryAllListApiResponse : AopObject
    {
        /// <summary>
        /// 签约的机构列表
        /// </summary>
        [XmlArray("orgs")]
        [XmlArrayItem("iot_identity_org_query_all_api_response")]
        public List<IotIdentityOrgQueryAllApiResponse> Orgs { get; set; }
    }
}
