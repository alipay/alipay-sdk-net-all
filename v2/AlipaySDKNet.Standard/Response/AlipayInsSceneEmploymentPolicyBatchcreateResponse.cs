using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEmploymentPolicyBatchcreateResponse.
    /// </summary>
    public class AlipayInsSceneEmploymentPolicyBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
