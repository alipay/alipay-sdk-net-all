using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletDestroyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletDestroyModel : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部订单号用户幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }

        /// <summary>
        /// 枚举值 alipay_user_id, mechant_user_id
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 销售产品吗
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
