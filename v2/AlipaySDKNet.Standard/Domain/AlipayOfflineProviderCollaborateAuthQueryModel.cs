using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateAuthQueryModel : AopObject
    {
        /// <summary>
        /// 授权申请单ID，即发起法人授权接口返回的申请单ID
        /// </summary>
        [XmlElement("auth_order_id")]
        public string AuthOrderId { get; set; }

        /// <summary>
        /// 设备绑定申请接口（alipay.offline.provider.collaborate.devicebind.apply）传入的out_biz_no字段
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
