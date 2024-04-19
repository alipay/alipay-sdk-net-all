using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationContentApplyResponse.
    /// </summary>
    public class AlipayCommerceOperationContentApplyResponse : AopResponse
    {
        /// <summary>
        /// 运营扩展数据 .
        /// </summary>
        [XmlElement("ext_data")]
        public OperationExtDataModel ExtData { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 申请记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 申请的内容相关的下游数据 ID ，比如 发奖对应奖品流水 id .
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
