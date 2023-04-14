using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletCardRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletCardRefundModel : AopObject
    {
        /// <summary>
        /// 卡号列表
        /// </summary>
        [XmlArray("asset_id_lists")]
        [XmlArrayItem("string")]
        public List<string> AssetIdLists { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 采购方账号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
