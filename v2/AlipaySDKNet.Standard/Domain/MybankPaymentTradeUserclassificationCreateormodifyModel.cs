using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeUserclassificationCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeUserclassificationCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 用户分类类别
        /// </summary>
        [XmlElement("classification_name")]
        public string ClassificationName { get; set; }

        /// <summary>
        /// 客户分类打标值,1:准入;0:取消
        /// </summary>
        [XmlElement("classification_value")]
        public string ClassificationValue { get; set; }

        /// <summary>
        /// 开放平台的开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
