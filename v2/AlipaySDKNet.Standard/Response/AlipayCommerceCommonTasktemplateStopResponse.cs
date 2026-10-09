using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplateStopResponse.
    /// </summary>
    public class AlipayCommerceCommonTasktemplateStopResponse : AopResponse
    {
        /// <summary>
        /// 任务模板终止结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
