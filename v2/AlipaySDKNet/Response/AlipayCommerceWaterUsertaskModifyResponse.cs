using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWaterUsertaskModifyResponse.
    /// </summary>
    public class AlipayCommerceWaterUsertaskModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改状态是否成功
        /// </summary>
        [XmlElement("change_result")]
        public bool ChangeResult { get; set; }

        /// <summary>
        /// NORMAL-正常还桶
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }
    }
}
