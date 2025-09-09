using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountDeleteResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowSubaccountDeleteResponse : AopResponse
    {
        /// <summary>
        /// 销户是否完成
        /// </summary>
        [XmlElement("cancel_account_flag")]
        public bool CancelAccountFlag { get; set; }
    }
}
