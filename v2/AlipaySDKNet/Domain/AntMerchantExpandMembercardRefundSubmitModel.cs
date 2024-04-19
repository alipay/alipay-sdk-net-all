using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMembercardRefundSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMembercardRefundSubmitModel : AopObject
    {
        /// <summary>
        /// 商家的安心充配置的唯一编号
        /// </summary>
        [XmlElement("member_product_id")]
        public string MemberProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
