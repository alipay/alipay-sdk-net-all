using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplatePublishResponse.
    /// </summary>
    public class AlipayCommerceCommonTasktemplatePublishResponse : AopResponse
    {
        /// <summary>
        /// 任务模板发布结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
