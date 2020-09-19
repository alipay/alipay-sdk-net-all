using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalCheckavailableResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalCheckavailableResponse : AopResponse
    {
        /// <summary>
        /// 返回灯火商家的ID
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 查询签约状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
