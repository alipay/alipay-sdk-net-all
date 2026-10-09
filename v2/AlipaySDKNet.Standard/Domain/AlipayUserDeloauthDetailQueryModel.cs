using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDeloauthDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDeloauthDetailQueryModel : AopObject
    {
        /// <summary>
        /// 商家查询日期为：date时，产生的解除授权记录
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 查询数量，单次查询的记录数上限
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 偏移位置，表示查询的起始位置是自(offset - 1)*limit，传入的offset必须大于0
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }
    }
}
