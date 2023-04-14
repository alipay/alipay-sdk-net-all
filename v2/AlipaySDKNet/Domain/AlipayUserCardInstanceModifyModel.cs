using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCardInstanceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCardInstanceModifyModel : AopObject
    {
        /// <summary>
        /// active_date：卡生效日期，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("active_date")]
        public string ActiveDate { get; set; }

        /// <summary>
        /// balance：余额，数字格式，最多支持2位小数
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// before_level：原先的等级名称
        /// </summary>
        [XmlElement("before_level")]
        public string BeforeLevel { get; set; }

        /// <summary>
        /// card_no：商家业务系统中的卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// changed_balance：变动的余额，数字格式，最多支持2位小数点
        /// </summary>
        [XmlElement("changed_balance")]
        public string ChangedBalance { get; set; }

        /// <summary>
        /// changed_point：变动的积分，数字格式，最多支持2位小数点
        /// </summary>
        [XmlElement("changed_point")]
        public string ChangedPoint { get; set; }

        /// <summary>
        /// expiry_date：卡失效日期，yyyy-MM-dd HH:mm:ss格式，若alipay.user.card.template.create接口设置的date_type为PERIOD，则此字段必传
        /// </summary>
        [XmlElement("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// level：等级名称
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// point：积分，数字格式，最多支持2位小数
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// user_id：蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
