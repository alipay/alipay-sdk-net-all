using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthExpressSigncardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthExpressSigncardQueryModel : AopObject
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// open_id，唯一，在查签约卡的时候，上游传入，由平台转成finsign能够识别的2088账号。可以通过openId SDK的api进行获取。
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
