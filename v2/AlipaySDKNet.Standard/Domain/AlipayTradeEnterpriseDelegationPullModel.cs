using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeEnterpriseDelegationPullModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeEnterpriseDelegationPullModel : AopObject
    {
        /// <summary>
        /// 分页参数，行数，限制多少条数据返回
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 查询多少页以后的数据
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// 授权状态，1 正常 2 取消
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
