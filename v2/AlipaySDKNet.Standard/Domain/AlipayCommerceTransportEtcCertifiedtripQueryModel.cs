using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcCertifiedtripQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcCertifiedtripQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝认证协议号
        /// </summary>
        [XmlElement("auth_agreement_no")]
        public string AuthAgreementNo { get; set; }

        /// <summary>
        /// 运单结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("out_waybill_no")]
        public string OutWaybillNo { get; set; }

        /// <summary>
        /// 不传入时默认至多返回最新10条数据
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据条数，默认10条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// true:接受行程推送，默认true false：不接受行程推送，查询行程
        /// </summary>
        [XmlElement("push_trip")]
        public bool PushTrip { get; set; }

        /// <summary>
        /// 运单开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
