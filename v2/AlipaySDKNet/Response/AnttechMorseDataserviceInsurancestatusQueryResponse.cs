using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseDataserviceInsurancestatusQueryResponse.
    /// </summary>
    public class AnttechMorseDataserviceInsurancestatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于链路问题定位排查和对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 查询月份的社保缴纳状态，true代表已缴纳，false代表未缴纳
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
