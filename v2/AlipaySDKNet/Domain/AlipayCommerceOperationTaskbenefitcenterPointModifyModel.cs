using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTaskbenefitcenterPointModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTaskbenefitcenterPointModifyModel : AopObject
    {
        /// <summary>
        /// 变动积分，以积分为单位
        /// </summary>
        [XmlElement("change_num")]
        public long ChangeNum { get; set; }

        /// <summary>
        /// 变动类型
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 商户自定义的积分变动事件编码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 对积分变动事件的详细描述
        /// </summary>
        [XmlElement("event_desc")]
        public string EventDesc { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 积分类型的唯一标识码，用于区分不同种类的积分
        /// </summary>
        [XmlElement("point_code")]
        public string PointCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
