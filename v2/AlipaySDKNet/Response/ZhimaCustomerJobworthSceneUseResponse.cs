using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthSceneUseResponse.
    /// </summary>
    public class ZhimaCustomerJobworthSceneUseResponse : AopResponse
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 业务中文结果信息
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }
    }
}
