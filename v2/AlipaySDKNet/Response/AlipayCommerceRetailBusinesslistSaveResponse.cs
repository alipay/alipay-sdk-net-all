using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBusinesslistSaveResponse.
    /// </summary>
    public class AlipayCommerceRetailBusinesslistSaveResponse : AopResponse
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 返回参数
        /// </summary>
        [XmlElement("response_list")]
        public string ResponseList { get; set; }
    }
}
