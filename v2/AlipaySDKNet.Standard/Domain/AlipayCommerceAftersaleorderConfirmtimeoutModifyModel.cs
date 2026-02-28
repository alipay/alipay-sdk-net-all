using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAftersaleorderConfirmtimeoutModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAftersaleorderConfirmtimeoutModifyModel : AopObject
    {
        /// <summary>
        /// 售后单id
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }

        /// <summary>
        /// 待用户确认延期小时数
        /// </summary>
        [XmlElement("wait_user_confirm_timeout_expand_hour")]
        public long WaitUserConfirmTimeoutExpandHour { get; set; }
    }
}
