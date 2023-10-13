using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAigcOrderQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAigcOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前订单状态中文描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图像处理结果，未完成时结果为空
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 当前订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 文字处理结果，未完成时结果为空
        /// </summary>
        [XmlArray("texts")]
        [XmlArrayItem("string")]
        public List<string> Texts { get; set; }
    }
}
