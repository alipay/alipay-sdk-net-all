using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileDeleteResponse.
    /// </summary>
    public class AlipayInsScenePetprofilePlatformprofileDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除结果，true表示成功，false表示失败
        /// </summary>
        [XmlElement("delete_result")]
        public bool DeleteResult { get; set; }
    }
}
