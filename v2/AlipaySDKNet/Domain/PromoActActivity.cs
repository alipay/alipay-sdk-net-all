using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoActActivity Data Structure.
    /// </summary>
    [Serializable]
    public class PromoActActivity : AopObject
    {
        /// <summary>
        /// JUMP代表c端点击去使用时跳转到使用地址，CLOSE代表关闭弹层
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("promo_activity_id")]
        public string PromoActivityId { get; set; }
    }
}
