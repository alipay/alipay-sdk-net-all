using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEmploymentProductOrderResponse.
    /// </summary>
    public class AlipayInsSceneEmploymentProductOrderResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
