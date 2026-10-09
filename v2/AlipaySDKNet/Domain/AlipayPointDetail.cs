using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPointDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPointDetail : AopObject
    {
        /// <summary>
        /// 回滚对应的订单分组
        /// </summary>
        [XmlElement("biz_group_no")]
        public string BizGroupNo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 该条数据主键id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 流入流出类型
        /// </summary>
        [XmlElement("in_out_type")]
        public string InOutType { get; set; }

        /// <summary>
        /// 积分订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 积分变更值
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("trans_memo")]
        public string TransMemo { get; set; }
    }
}
