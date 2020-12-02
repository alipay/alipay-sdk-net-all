using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseMessageDynamicicondataModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseMessageDynamicicondataModifyModel : AopObject
    {
        /// <summary>
        /// 微动效业务编码
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 微动效数据
        /// </summary>
        [XmlElement("op_data")]
        public SingleDynamicData OpData { get; set; }

        /// <summary>
        /// 操作类型： ADD-新增数据 DEL-删除数据
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
