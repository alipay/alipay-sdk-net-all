using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseDataDataserviceQueryResponse.
    /// </summary>
    public class AnttechMorseDataDataserviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于链路问题定位排查和对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 结果字段，用于展示定制模型打分结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
