using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOnepassQueryResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasOnepassQueryResponse : AopResponse
    {
        /// <summary>
        /// 一键登录状态。PROCESSING：初始化；SUCCESS：本机校验成功（页面输入的手机号与当前流量卡号一致）；FAIL：本机校验失败（页面输入的手机号与当前流量卡号不一致）。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
