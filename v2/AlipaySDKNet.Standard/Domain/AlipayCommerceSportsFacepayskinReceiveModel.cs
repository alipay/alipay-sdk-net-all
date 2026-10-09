using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsFacepayskinReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsFacepayskinReceiveModel : AopObject
    {
        /// <summary>
        /// 支付宝客户端版本号
        /// </summary>
        [XmlElement("client_version")]
        public string ClientVersion { get; set; }

        /// <summary>
        /// 北京时间的皮肤的过期日期,当日的23点59分59秒 会与之前申请皮肤上架里的日期比较，取两者的最小值
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 付款码皮肤ID
        /// </summary>
        [XmlElement("skin_id")]
        public string SkinId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
