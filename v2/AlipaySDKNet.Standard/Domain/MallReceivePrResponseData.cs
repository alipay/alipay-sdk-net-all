using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallReceivePrResponseData Data Structure.
    /// </summary>
    [Serializable]
    public class MallReceivePrResponseData : AopObject
    {
        /// <summary>
        /// 采购商城申请单id
        /// </summary>
        [XmlElement("pur_req_id")]
        public string PurReqId { get; set; }

        /// <summary>
        /// 下单成功后跳转地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
