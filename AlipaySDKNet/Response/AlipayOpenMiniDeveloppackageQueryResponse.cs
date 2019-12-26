using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniDeveloppackageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDeveloppackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 单个小程序的启动结果VO
        /// </summary>
        [XmlElement("single_start_app_vo")]
        public SingleStartAppVO SingleStartAppVo { get; set; }
    }
}
