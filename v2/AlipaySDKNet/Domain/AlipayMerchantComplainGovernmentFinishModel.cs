using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantComplainGovernmentFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantComplainGovernmentFinishModel : AopObject
    {
        /// <summary>
        /// 支付宝侧投诉工单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 平台完结时的结案陈词
        /// </summary>
        [XmlElement("finish_memo")]
        public string FinishMemo { get; set; }

        /// <summary>
        /// 处理该笔投诉的政府单位
        /// </summary>
        [XmlElement("government_agency")]
        public string GovernmentAgency { get; set; }
    }
}
