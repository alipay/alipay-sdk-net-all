using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOneloginQueryResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasOneloginQueryResponse : AopResponse
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 一键登录状态。PROCESSING：初始化；SUCCESS：取号成功（返回手机号）；FAIL：取号失败。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
