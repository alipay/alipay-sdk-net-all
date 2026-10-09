using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyAcardTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyAcardTaskQueryModel : AopObject
    {
        /// <summary>
        /// 外部客户保证唯一性，平台以此字段作幂等性处理。out_biz_id和task_id不能同时为空。
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 制卡请求受理后的制卡任务唯一ID，与outBizId一一对应。out_biz_id和task_id不能同时为空。
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
