using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgUserQueryListApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgUserQueryListApiResponse : AopObject
    {
        /// <summary>
        /// 人脸批量查询条件
        /// </summary>
        [XmlArray("face_info")]
        [XmlArrayItem("iot_identity_org_user_query_api_response")]
        public List<IotIdentityOrgUserQueryApiResponse> FaceInfo { get; set; }
    }
}
