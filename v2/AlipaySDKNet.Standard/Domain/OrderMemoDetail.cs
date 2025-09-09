using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderMemoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OrderMemoDetail : AopObject
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("axf_order_memo_info")]
        public AxfOrderMemoInfo AxfOrderMemoInfo { get; set; }

        /// <summary>
        /// 备注操作时间。格式yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 操作类型。表示此次操作类型。新增备注，修改备注或删除备注
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
