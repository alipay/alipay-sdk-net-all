using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCouponQrcodeMerchantBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponQrcodeMerchantBatchcreateModel : AopObject
    {
        /// <summary>
        /// 生成的码关联的产品，喜气红包场景填CROWD_CELEBRATE_CASH
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 每组码的个数，每组码最多600个
        /// </summary>
        [XmlElement("code_count")]
        public string CodeCount { get; set; }

        /// <summary>
        /// 每批需要生成的码组的数量
        /// </summary>
        [XmlElement("code_group_count")]
        public string CodeGroupCount { get; set; }

        /// <summary>
        /// 外部业务号，根据这个单据号关联此批次生成的所有二维码
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
