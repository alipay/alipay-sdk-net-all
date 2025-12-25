using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseRegistercarApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseRegistercarApplyModel : AopObject
    {
        /// <summary>
        /// 备案车辆列表
        /// </summary>
        [XmlArray("car_infos")]
        [XmlArrayItem("car_infos")]
        public List<CarInfos> CarInfos { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }
    }
}
