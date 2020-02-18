using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenInviteOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenInviteOrderCreateModel : AopObject
    {
        /// <summary>
        /// isv业务系统的申请单id
        /// </summary>
        [XmlElement("isv_biz_id")]
        public string IsvBizId { get; set; }

        /// <summary>
        /// isv平台的回跳地址。商户从伙伴平台跳转过来签约提交申请后，在结果页可以回跳到合作伙伴指定的页面，
        /// </summary>
        [XmlElement("isv_return_url")]
        public string IsvReturnUrl { get; set; }
    }
}
