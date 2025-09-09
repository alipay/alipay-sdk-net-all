using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandLeadsModifyResponse.
    /// </summary>
    public class AntMerchantExpandLeadsModifyResponse : AopResponse
    {
        /// <summary>
        /// leads信息修改过程中返回的不通过信息原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 如果返回true,则代表需要审核,异步消息通知,一般是四要素的修改需要审核,其他一些关联信息修改不需要审核
        /// </summary>
        [XmlElement("need_audit")]
        public bool NeedAudit { get; set; }

        /// <summary>
        /// 是否通过
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }
    }
}
