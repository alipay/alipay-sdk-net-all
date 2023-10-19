using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceXlightTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceXlightTaskQueryModel : AopObject
    {
        /// <summary>
        /// 广告检索时每个任务返回的唯一流水号，用此流水号来查询用户是否完成了这条任务
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 支付宝用户在应用维度下的唯一id
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
