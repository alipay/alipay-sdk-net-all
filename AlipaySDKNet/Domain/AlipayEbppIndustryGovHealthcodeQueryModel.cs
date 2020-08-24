using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovHealthcodeQueryModel : AopObject
    {
        /// <summary>
        /// json格式的业务相关信息, 因健康码不同的省市存在个性化的业务参数需求，在本字段内传入
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 业务类型，医护天使码: MEDIC_ANGEL; 健康码: HEALTHCODE。为空时默认为健康码HEALTHCODE
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }
    }
}
