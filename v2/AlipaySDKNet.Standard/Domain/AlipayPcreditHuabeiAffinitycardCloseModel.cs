using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAffinitycardCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAffinitycardCloseModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务单号，用于幂等，不超过32位
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户花呗联名卡产品账户号
        /// </summary>
        [XmlElement("user_prod_account_no")]
        public string UserProdAccountNo { get; set; }
    }
}
