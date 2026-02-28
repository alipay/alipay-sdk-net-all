using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAffinitycardIdcardnoApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAffinitycardIdcardnoApplyModel : AopObject
    {
        /// <summary>
        /// 业务场景，hellobike_hb_card-哈罗花呗联名卡
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 商户与支付宝签约的PID，从商户与支付宝签约的销售方案中获取
        /// </summary>
        [XmlElement("merchant_partner_id")]
        public string MerchantPartnerId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部业务单号，用于幂等，不超过32位
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
