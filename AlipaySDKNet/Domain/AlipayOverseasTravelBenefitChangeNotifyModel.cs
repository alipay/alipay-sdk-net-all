using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelBenefitChangeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelBenefitChangeNotifyModel : AopObject
    {
        /// <summary>
        /// 收单站在gn的id
        /// </summary>
        [XmlElement("acquirer_id")]
        public string AcquirerId { get; set; }

        /// <summary>
        /// 权益详情列表
        /// </summary>
        [XmlArray("benefit_detail_info_list")]
        [XmlArrayItem("benefit_detail_info")]
        public List<BenefitDetailInfo> BenefitDetailInfoList { get; set; }

        /// <summary>
        /// 发卡站在gn的id
        /// </summary>
        [XmlElement("psp_id")]
        public string PspId { get; set; }
    }
}
