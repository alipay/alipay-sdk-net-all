using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSearchCityQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalSearchCityQueryResponse : AopResponse
    {
        /// <summary>
        /// 省份数据列表
        /// </summary>
        [XmlElement("province_list")]
        public ProvinceVo ProvinceList { get; set; }
    }
}
