using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSelleradmitRealtimeCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiSelleradmitRealtimeCertifyModel : AopObject
    {
        /// <summary>
        /// 支付宝id
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 请求来源应用名
        /// </summary>
        [XmlElement("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 店铺所属行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 店铺主营类目，多个逗号分隔
        /// </summary>
        [XmlElement("main_category")]
        public string MainCategory { get; set; }

        /// <summary>
        /// 卖家店铺归属平台
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 卖家准入场景
        /// </summary>
        [XmlElement("seller_admit_scene")]
        public string SellerAdmitScene { get; set; }

        /// <summary>
        /// 卖家店铺id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }
    }
}
