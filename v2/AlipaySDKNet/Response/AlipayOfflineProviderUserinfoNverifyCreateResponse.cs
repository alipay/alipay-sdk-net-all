using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderUserinfoNverifyCreateResponse.
    /// </summary>
    public class AlipayOfflineProviderUserinfoNverifyCreateResponse : AopResponse
    {
        /// <summary>
        /// 用户VID，是传入身份信息之后，和身份证一一对应的ID，服务商需要保存下来，用于后续核身时关联系统内部身份信息。多次入库返回的VID是相同的。
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
