using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseDataserviceInsurancetypeQueryResponse.
    /// </summary>
    public class AnttechMorseDataserviceInsurancetypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于链路问题定位排查和对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 是否为灵活就业，true代表是灵活就业，false代表不是灵活就业
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
