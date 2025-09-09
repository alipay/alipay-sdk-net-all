using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateAuthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateAuthCreateModel : AopObject
    {
        /// <summary>
        /// 将要进行设备绑定的smid，其他人将向<a href="https://opendocs.alipay.com/p/03rq2b?pathHash=f91a1cda">完成smid商户实名认证</a>的法人或联系人申请授权。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
