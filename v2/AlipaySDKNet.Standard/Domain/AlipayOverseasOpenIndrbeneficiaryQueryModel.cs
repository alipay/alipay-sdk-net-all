using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndrbeneficiaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndrbeneficiaryQueryModel : AopObject
    {
        /// <summary>
        /// 收款方名称
        /// </summary>
        [XmlElement("beneficiary_name")]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// 场景类型: TUITION 留学缴费 HOUSE_RENTAL 留学租房
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
