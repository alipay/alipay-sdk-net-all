using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEmploymentBatchpreorderSubmitResponse.
    /// </summary>
    public class AlipayInsSceneEmploymentBatchpreorderSubmitResponse : AopResponse
    {
        /// <summary>
        /// 外部幂等单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
